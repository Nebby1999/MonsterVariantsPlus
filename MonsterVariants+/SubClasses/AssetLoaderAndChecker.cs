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
        public static void PreventBadValues(ConfigFile config)
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

            foreach (ConfigEntry<int> entry in itemDropChanceConfigs)
            {
                if(entry.Value < 0 || entry.Value > 100)
                {
                    entry.Value = entry.DefaultValue;
                }
            }
        }
    }
}
