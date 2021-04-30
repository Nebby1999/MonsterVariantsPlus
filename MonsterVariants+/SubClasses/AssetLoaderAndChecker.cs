using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses
{
    public class AssetLoaderAndChecker
    {
        public static bool checkForMod(string modKey)
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
        public static void LoadAssets(AssetBundle assets)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MonsterVariantsPlus.monstervariantsplus_assets"))
            {
                assets = AssetBundle.LoadFromStream(stream);
            }
            var materialAssets = MainPlugin.MainAssets.LoadAllAssets<Material>();
            foreach (Material material in materialAssets)
            {
                if (!material.shader.name.StartsWith("Stubbed")) { continue; }
                var replacementShader = Resources.Load<Shader>(ShaderLookup[material.shader.name.ToLower()]);
                if (replacementShader) { material.shader = replacementShader; }
            }
        }
    }
}
