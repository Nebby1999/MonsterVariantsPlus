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
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.2.9")]
    public class MainPlugin : BaseUnityPlugin
    {
        public static MainPlugin instance;
        internal static bool hasClayMan;
        internal static bool hasAncientWisp;
        public static AssetBundle MainAssets; //Contains custom assets
        public static Dictionary<string, string> ShaderLookup = new Dictionary<string, string>()
        {
            {"stubbed hopoo games/deferred/standard", "shaders/deferred/hgstandard"} //Dictionary for checking the default shader values
        };
        public void Awake()
        {
            //Asset Loading shenanigans, special thanks to Komrade for helping a tone with this.
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonsterVariantsPlus.monstervariantsplus_assets"))
                {
                    MainAssets = AssetBundle.LoadFromStream(stream);
                }
                var materialAssets = MainPlugin.MainAssets.LoadAllAssets<Material>();
                foreach (Material material in materialAssets)
                {
                    if (!material.shader.name.StartsWith("Stubbed")) { continue; }
                    var replacementShader = Resources.Load<Shader>(ShaderLookup[material.shader.name.ToLower()]);
                    if (replacementShader) { material.shader = replacementShader; }
                }
            }
            ConfigLoader.SetupConfigLoader(Config); //Initializes the Config
            ConfigLoader.ReadConfig(Config);
            SubClasses.Skills.CustomSkills.RegisterSkills();
            if(BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.Moffein.ClayMen"))
            {
                hasClayMan = true;
                Logger.LogMessage("Moffein's Clayman has been detected, enabling Clayman Variant(s).");
            }
            if(BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.Moffein.AncientWisp"))
            {
                hasAncientWisp = true;
                Logger.LogMessage("Moffein's Ancient Wisp has been detected, enabling Ancient Wisp Variant(s).");
            }
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
                    for (int i = 0; i < 3; i++)
                    {
                        Vector3 position = DamageReport.victimBody.corePosition + (2f * UnityEngine.Random.insideUnitSphere);

                        DirectorSpawnRequest directorSpawnRequest = new DirectorSpawnRequest((SpawnCard)Resources.Load(string.Format("SpawnCards/CharacterSpawnCards/cscLesserWisp")), new DirectorPlacementRule
                        {
                            placementMode = DirectorPlacementRule.PlacementMode.Direct,
                            minDistance = 0f,
                            maxDistance = 0f,
                            position = position
                        }, RoR2Application.rng);

                        directorSpawnRequest.summonerBodyObject = DamageReport.victimBody.gameObject;

                        GameObject jelly = DirectorCore.instance.TrySpawnObject(directorSpawnRequest);
                        if (jelly)
                        {
                            CharacterMaster master = jelly.GetComponent<CharacterMaster>();
                            jelly.GetComponent<Inventory>().SetEquipmentIndex(DamageReport.victimBody.inventory.currentEquipmentIndex);
                        }
                    }
                }
                orig(self, DamageReport);
            };
        }
        public void Start()
        {
            CustomVariants.RegisterCustomVariants();
        }
    }
}
