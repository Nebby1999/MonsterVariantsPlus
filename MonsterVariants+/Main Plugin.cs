using BepInEx;
using RoR2;
using MonsterVariantsPlus.SubClasses;
using MonsterVariantsPlus.SubClasses.RewardsSystem;
using MonsterVariantsPlus.SubClasses.Items;
using UnityEngine;
using MonsterVariants.Components;
using System.Security;
using System.Security.Permissions;
using R2API.Utils;
using R2API;
using System.Reflection;
using System.Linq;
using MonsterVariantsPlus.SubClasses.Projectiles;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace MonsterVariantsPlus
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
    [BepInDependency("com.Moffein.ClayMen", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("com.Moffein.AncientWisp", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("com.Nebby1999.ArchWisps", BepInDependency.DependencyFlags.SoftDependency)]
    [R2APISubmoduleDependency(nameof(ProjectileAPI), nameof(LanguageAPI), nameof(ArtifactAPI), nameof(PrefabAPI))]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.4.6")]
    public class MainPlugin : BaseUnityPlugin
    {
        public static MainPlugin instance;
        internal static bool hasClayMan;
        internal static bool hasAncientWisp;
        internal static bool hasArchWisp;
        internal static bool hasMysticItems;

        //used in variant items
        public List<MVPItemBase> Items = new List<MVPItemBase>();

        //Used in enemy spawning behavior of new variants
        private static int amount;
        private static string enemyCard;

        public void Awake()
        {
            Debug.Log("MVP: Proceeding to check for mod compatibility...");
            //Check if Mods are loaded.
            hasClayMan = AssetLoaderAndChecker.CheckForMod("com.Moffein.ClayMen");
            hasAncientWisp = AssetLoaderAndChecker.CheckForMod("com.Moffein.AncientWisp");
            hasArchWisp = AssetLoaderAndChecker.CheckForMod("com.Nebby1999.ArchaicWisps");
            hasMysticItems = AssetLoaderAndChecker.CheckForMod("com.themysticsword.mysticsitems");
            Debug.Log("MVP: Mod Compat Checker finished.");
            //Register Hooks
            Debug.Log("MVP: Proceeding to create custom hooks...");
            RegisterHooks();
            Debug.Log("MVP: Hook creation finished.");
            //Load Monster Variant Assets
            Debug.Log("MVP: Proceeding to load Assets...");
            AssetLoaderAndChecker.LoadAssets();
            //Initializes Config
            Debug.Log("MVP: Proceeding to initialize the Config File.");
            ConfigLoader.SetupConfigLoader(Config);
            //Initializes variant spawn chances
            ConfigLoader.ReadConfig(Config);
            Debug.Log("MVP: Config creation finished.");
            //Make sure config values aren't invalid.
            if (ConfigLoader.EnableConfigcheck)
            {
                Debug.Log("MVP: " + ConfigLoader.EnableConfigCheckConfig.Definition.Key + "Is set to True, proceeding to check for bad values in the config...");
                AssetLoaderAndChecker.PreventBadValues(Config);
            }
            else
            {
                Debug.Log("MVP: " + ConfigLoader.EnableConfigCheckConfig.Definition.Key + "Is set to False, skipping to skill registration...");
            }
            //Registers skills
            Debug.Log("MVP: Proceeding to register Monster Variants Skills...");
            SubClasses.Skills.CustomSkills.RegisterSkills();
            Debug.Log("MVP: Monster Variants Skills registered...");
            //Register Artifact of Variance
            if(ConfigLoader.EnableArtifactOfVariance)
            {
                Debug.Log("MVP: Proceeding to Register the Artifact of Variance");
                Artifact.InitializeArtifact();
                Debug.Log("MVP: Artifact Registered...");
            }
            Debug.Log("MVP: Proceeding to register prefabs");
            //Registers Prefabs... hopefully?
            var Prefabs = Assembly.GetExecutingAssembly().GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(typeof(PrefabBase)));
            foreach (var prefabType in Prefabs)
            {
                PrefabBase prefab = (PrefabBase)System.Activator.CreateInstance(prefabType);
                prefab.Init();
            }
            //Initializes custom items for monster variants, thanks Komrade for the boilerplate! <3
            var ItemTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(typeof(MVPItemBase)));

            foreach (var itemType in ItemTypes)
            {
                MVPItemBase item = (MVPItemBase)System.Activator.CreateInstance(itemType);
                
                if (ValidateItem(item, Items))
                {
                    item.Init();
                }
            }
            //main hook
            On.RoR2.DeathRewards.OnKilledServer += (orig, self, DamageReport) => {
                foreach (VariantHandler enemy in DamageReport.victimBody.GetComponents<VariantHandler>())
                {
                    if (enemy.isVariant && (DamageReport.victimTeamIndex == (TeamIndex)2))
                    {
                        if(ConfigLoader.CertainVariantsSpawnMoreEnemies)
                        {
                            TrySpawnEnemy(DamageReport.victimBody);
                        }
                        if (ConfigLoader.EnableItemRewards)
                        {
                            if (Run.instance.isRunStopwatchPaused && ConfigLoader.HiddenRealmItemdropBehavior != "Unchanged")
                            {
                                if (ConfigLoader.HiddenRealmItemdropBehavior == "Halved")
                                {
                                    int rng = UnityEngine.Random.Range(1, 20);
                                    if (rng > 10)
                                    {
                                        ExtraRewards.TryExtraReward(enemy, DamageReport.victimBody, DamageReport.attackerBody);
                                    }
                                }
                                else //(Hidden Realm item drop behavior is "Never")
                                {
                                }
                            }
                            else
                            {
                                ExtraRewards.TryExtraReward(enemy, DamageReport.victimBody, DamageReport.attackerBody);
                            }
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
                orig(self, DamageReport);
            };
        }
        public void Start()
        {
            CustomVariants.RegisterCustomVariants();
        }
        public static void RegisterHooks()
        {
            new Hook(typeof(VariantHandler).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance), typeof(MainPlugin).GetMethod("MonsterVariantStartHook"));
            Debug.Log("MVP: Added VariantHandler.Start hook.");
            new Hook(typeof(VariantHandler).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance), typeof(Artifact).GetMethod("MonsterVariantAwakeHook"));
            Debug.Log("MVP: Added VariantHandler.Awake hook");
        }
        public static void MonsterVariantStartHook(Action<VariantHandler> orig, VariantHandler self)
        {
            orig(self);
            var variantCharacterBody = self.GetComponent<CharacterBody>();
            if(variantCharacterBody.baseNameToken == "Ghost of Kjaro")
            {
                GiveEnemyEquipment(variantCharacterBody, "AffixRed");
            }
            if(variantCharacterBody.baseNameToken == "Ghost of Runald")
            {
                GiveEnemyEquipment(variantCharacterBody, "AffixWhite");
            }
        }

        public static void TrySpawnEnemy(CharacterBody body)
        {
            string variantName = body.baseNameToken;
            bool variantIsSpecial = true; //Wether or not this variant spawns enemies on death.
            switch (variantName)
            {
                case "Wisp Amalgamate":
                    enemyCard = "LesserWisp";
                    amount = 5;
                    break;
                case "M.O.A.J.":
                    enemyCard = "Jellyfish";
                    amount = 5;
                    break;
                case "Amalgamated Ancient Wisp":
                    enemyCard = "GreaterWisp";
                    amount = 5;
                    break;
                default:
                    variantIsSpecial = false;
                    break;
            }
            if(variantIsSpecial)
            {
                Vector3 position = body.corePosition + (amount * UnityEngine.Random.insideUnitSphere);

                DirectorSpawnRequest directorSpawnRequest = new DirectorSpawnRequest((SpawnCard)Resources.Load(string.Format("SpawnCards/CharacterSpawnCards/csc" + enemyCard)), new DirectorPlacementRule
                {
                    placementMode = DirectorPlacementRule.PlacementMode.Direct,
                    minDistance = 0f,
                    maxDistance = 4f,
                    position = position
                }, RoR2Application.rng);

                directorSpawnRequest.summonerBodyObject = body.gameObject;
                for (int i = 0; i < amount; i++)
                {

                    GameObject enemy = DirectorCore.instance.TrySpawnObject(directorSpawnRequest);
                    if (enemy)
                    {
                        CharacterMaster master = enemy.GetComponent<CharacterMaster>();
                        enemy.GetComponent<Inventory>().SetEquipmentIndex(body.inventory.currentEquipmentIndex);
                    }
                }
            }
        }
        public static void GiveEnemyEquipment(CharacterBody enemyBody, string equipmentToGive)
        {
            enemyBody.master.GetComponent<Inventory>().GiveEquipmentString(equipmentToGive);
        }
        public bool ValidateItem(MVPItemBase item, List<MVPItemBase> itemList)
        {
            itemList.Add(item);
            return true;
        }
    }
}
