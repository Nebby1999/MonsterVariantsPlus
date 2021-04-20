/*
 * Main plugin class, tells Bepinex that this is a Mod.
 * Class initializes the Config files, and it's main purpose is checking if the killed monster was a Variant.
*/
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
//    [BepInDependency("com.Moffein.ClayMen", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.2.5")]
    public class MainPlugin : BaseUnityPlugin
    {
        //private static bool hasClayMan;
        public static AssetBundle MainAssets; //Needed to load custom assets
        public static Dictionary<string, string> ShaderLookup = new Dictionary<string, string>()
        {
            {"stubbed hopoo games/deferred/standard", "shaders/deferred/hgstandard"}
        };
        public void Awake()
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
                orig(self, DamageReport);
            };
        }
        public void Start()
        {
            CustomVariants.RegisterCustomVariants();
        }
    }
}
