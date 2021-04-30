using BepInEx.Configuration;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses
{
    public class AssetLoaderAndChecker
    {
        public static AssetBundle MainAssets; //Contains custom assets
        public static bool CheckForMod(string modKey)
        {
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(modKey))
            {
                Debug.Log(modKey + " Detected! enabling the variants tied to the mod...");
                return true;
            }
            return false;
        }
        //Asset Loading Shenanigans, huge thanks to komrade spectre for helping tons with this.
        public static Dictionary<string, string> ShaderLookup = new Dictionary<string, string>()
        {
            {"stubbed hopoo games/deferred/standard", "shaders/deferred/hgstandard"} //Dictionary for checking the default shader values
        };
        public static void LoadAssets()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonsterVariantsPlus.monstervariantsplus_assets"))
            {
                MainAssets = AssetBundle.LoadFromStream(stream);
            }
            var materialAssets = MainAssets.LoadAllAssets<Material>();
            foreach (Material material in materialAssets)
            {
                if (!material.shader.name.StartsWith("Stubbed")) { continue; }
                var replacementShader = Resources.Load<Shader>(ShaderLookup[material.shader.name.ToLower()]);
                if (replacementShader) { material.shader = replacementShader; }
            }
        }
        public static bool PreventBadValues(ConfigFile config)
        {
            List<ConfigEntry<int>> itemDropChanceConfigs = new List<ConfigEntry<int>>();
            itemDropChanceConfigs.Add(ConfigLoader.CommonWhiteChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.CommonGreenChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.CommonRedChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.UncommonWhiteChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.UncommonGreenChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.UncommonRedChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.RareWhiteChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.RareGreenChanceConfig);
            itemDropChanceConfigs.Add(ConfigLoader.RareRedChanceConfig);

            List<ConfigEntry<float>> multiplierConfigs = new List<ConfigEntry<float>>();
            multiplierConfigs.Add(ConfigLoader.CommonMoneyMultConfig);
            multiplierConfigs.Add(ConfigLoader.UncommonMoneyMultConfig);
            multiplierConfigs.Add(ConfigLoader.RareMoneyMultConfig);
            multiplierConfigs.Add(ConfigLoader.CommonXPMultConfig);
            multiplierConfigs.Add(ConfigLoader.UncommonXPMultConfig);
            multiplierConfigs.Add(ConfigLoader.RareXPMultConfig);

            List<ConfigEntry<float>> variantSpawnChanceConfigs = new List<ConfigEntry<float>>();
            variantSpawnChanceConfigs.Add(ConfigLoader.LeastestWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AlmostButNotQuiteArchaicWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.SteelContraptionSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AluminumContraptionSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.MortarCrabSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.VampiricTemplarSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.ADShroomSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.HealerShroomSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.MamaShroomSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AdolescentSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.ChildSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.BruiserImpSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AlphaBisonSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.WispAmalgamateSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.KindaGreatButNotGreaterWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.IncineratingElderLemurianSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.SwarmerProbeSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.SunPriestSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.HoarderSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.StarvingDunestriderSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.DevourerDunestriderspawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.MalfunctioningSolusControlUnitSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.MalfunctioningAlloyWorshipUnitSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.ClaySoldierSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.EnragedWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AmalgamatedAncientWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.AeonicWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.KindaArchaicWispSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.GlandBeetleGuardBruteSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.GlandBeetleGuardSharpshooterSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.SquidChaingunSpawnChance);
            variantSpawnChanceConfigs.Add(ConfigLoader.SquidSniperSpawnChance);

            foreach (ConfigEntry<int> entry in itemDropChanceConfigs)
            {
                if(entry.Value < 0 || entry.Value > 100)
                {
                    Debug.LogError("Invalid Value detected in " + entry.Definition.Key + "! Restoring value to default Value.");
                    entry.Value = (int)entry.DefaultValue;
                }
            }
            foreach (ConfigEntry<float> entry in multiplierConfigs)
            {
                if(entry.Value < 1.0)
                {
                    Debug.LogError("Invalid Value deceted in " + entry.Definition.Key + "! Restoring value to default Value.");
                    entry.Value = (float)entry.DefaultValue;
                }
            }
            foreach (ConfigEntry<float> entry in variantSpawnChanceConfigs)
            {
                if(entry.Value < 0 || entry.Value > 100)
                {
                    Debug.LogError("Invalid value detected in " + entry.Definition.Key + "! Restoring value to default Value.");
                    entry.Value = (float)entry.DefaultValue;
                }
            }
            Debug.Log("Config Checker finished succesfully.");
            return false;
        }
    }
}
