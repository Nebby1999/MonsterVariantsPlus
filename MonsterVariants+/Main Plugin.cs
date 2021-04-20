/*
 * Main plugin class, tells Bepinex that this is a Mod.
 * Class initializes the Config files, and it's main purpose is checking if the killed monster was a Variant.
*/
using BepInEx;
using BepInEx.Logging;
using RoR2;
using MonsterVariantsPlus.SubClasses;
using MonsterVariants;
using UnityEngine;
using System.Collections.Generic;
using MonsterVariants.Components;
using System.Reflection;

namespace MonsterVariantsPlus
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
//    [BepInDependency("com.Moffein.ClayMen", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.2.4")]
    public class MainPlugin : BaseUnityPlugin
    {
        //private static bool hasClayMan;
        public static AssetBundle MainAssets; //Needed to load custom assets
        public void Awake()
        {

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonsterVariantsPlus.monstervariantsplus_assets"))
            {
                MainAssets = AssetBundle.LoadFromStream(stream);
            }
            ConfigLoader.SetupConfigLoader(Config); //Initializes the Config
            /*if(BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("com.Moffein.ClayMen"))
            {
                hasClayMan = true;
                Logger.LogMessage("Moffein's Clayman has been detected, enabling Clayman Variant(s).");
            }*/
            On.RoR2.DeathRewards.OnKilledServer += (orig, self, DamageReport) =>
            {
                foreach (VariantHandler enemy in DamageReport.victimBody.GetComponents<VariantHandler>())
                {
                    if(enemy.isVariant)
                    {
                        if (ConfigLoader.EnableItemRewards)
                        {
                            ExtraRewards.TryExtraReward(enemy, DamageReport.victimBody, DamageReport.attackerBody); //Tries to spawn an item
                        }
                        if (ConfigLoader.EnableGoldRewards)
                        {
                            uint multipliedGold = MultiplyGold.MultiplyMoney(self.goldReward, enemy); //Multiplies the money given to the player
                            self.goldReward = multipliedGold; //Sets the Gold given to the player the value taken from "multipliedGold"
                        }
                        if (ConfigLoader.EnableXPRewards)
                        {
                            uint multipliedXP = MultiplyXP.MultiplyExperience(self.expReward, enemy); //Multiplies the XP given to the player
                            self.expReward = multipliedXP; //Sets the Gold given to the player the value taken from "multipliedXP"
                        }
                    }
                }
                orig(self, DamageReport);
            };
        }
        public void Start() //As soon as the game begins, register variants
        {
            CustomVariants.RegisterCustomVariants();
        }
    }
}
