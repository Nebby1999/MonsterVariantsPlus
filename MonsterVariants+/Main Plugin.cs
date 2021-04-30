using BepInEx;
using RoR2;
using MonsterVariantsPlus.SubClasses;
using UnityEngine;
using System.Collections.Generic;
using MonsterVariants.Components;
using System.Reflection;

namespace MonsterVariantsPlus
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
    [BepInDependency("com.Moffein.ClayMen", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("com.Moffein.AncientWisp", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("com.Nebby1999.ArchWisps", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.3.1")]
    public class MainPlugin : BaseUnityPlugin
    {
        public static MainPlugin instance;
        internal static bool hasClayMan;
        internal static bool hasAncientWisp;
        internal static bool hasArchWisp;


        public void Awake()
        {
            //Check if Mods are loaded.
            hasClayMan = AssetLoaderAndChecker.CheckForMod("com.Moffein.ClayMen");
            hasAncientWisp = AssetLoaderAndChecker.CheckForMod("com.Moffein.AncientWisp");
            hasArchWisp = AssetLoaderAndChecker.CheckForMod("com.Nebby1999.ArchaicWisps");

            //Load Monster Variant Assets
            AssetLoaderAndChecker.LoadAssets();

            //Initializes the rewards Config
            ConfigLoader.SetupConfigLoader(Config);
            //Initializes the custom variants config
            ConfigLoader.ReadConfig(Config);
            //Make sure config values aren't invalid.
            if(ConfigLoader.EnableConfigcheck)
            {
                AssetLoaderAndChecker.PreventBadValues(Config);
            }
            //Registers skills
            SubClasses.Skills.CustomSkills.RegisterSkills();

            //hook
            On.RoR2.DeathRewards.OnKilledServer += (orig, self, DamageReport) =>
            {
                foreach (VariantHandler enemy in DamageReport.victimBody.GetComponents<VariantHandler>())
                {
                    if(enemy.isVariant && (DamageReport.victimTeamIndex == (TeamIndex)2))
                    {
                        if (ConfigLoader.EnableItemRewards)
                        {
                            ExtraRewards.TryExtraReward(enemy, DamageReport.victimBody, DamageReport.attackerBody);
                        }
                        if (ConfigLoader.EnableGoldRewards)
                        {
                            uint multipliedGold = MultiplyGold.MultiplyMoney(self.goldReward, enemy);
                            self.goldReward = multipliedGold;
                        }
                        if (ConfigLoader.EnableXPRewards)
                        {
                            uint multipliedXP = MultiplyXP.MultiplyExperience(self.expReward, enemy);
                            self.expReward = multipliedXP;
                        }
                    }
                }
                //Remove this once rob implements deathState replacements.
                if (DamageReport.victimBody.baseNameToken == "Wisp Amalgamate")
                {
                    SpawnEnemy("LesserWisp", 5, DamageReport);
                }
                else if(DamageReport.victimBody.baseNameToken == "Amalgamated Ancient Wisp")
                {
                    SpawnEnemy("GreaterWisp", 5, DamageReport);
                }
                else if(DamageReport.victimBody.baseNameToken == "M.O.A.J")
                {
                    SpawnEnemy("Jellyfish", 5, DamageReport);
                }
                orig(self, DamageReport);
            };
        }
        public void SpawnEnemy(string spawnCard, int amount, DamageReport damageReport)
        {
            Vector3 position = damageReport.victimBody.corePosition + (2f * Random.insideUnitSphere);

            DirectorSpawnRequest directorSpawnRequest = new DirectorSpawnRequest((SpawnCard)Resources.Load(string.Format("SpawnCards/CharacterSpawnCards/csc" + spawnCard)), new DirectorPlacementRule
            {
                placementMode = DirectorPlacementRule.PlacementMode.Direct,
                minDistance = 0f,
                maxDistance = 0f,
                position = position
            }, RoR2Application.rng);

            directorSpawnRequest.summonerBodyObject = damageReport.victimBody.gameObject;
            for (int i = 0; i < amount; i++)
            {

                GameObject enemy = DirectorCore.instance.TrySpawnObject(directorSpawnRequest);
                if (enemy)
                {
                    CharacterMaster master = enemy.GetComponent<CharacterMaster>();
                    enemy.GetComponent<Inventory>().SetEquipmentIndex(damageReport.victimBody.inventory.currentEquipmentIndex);
                }
            }
        }
        public void Start()
        {
            CustomVariants.RegisterCustomVariants();
        }
    }
}
