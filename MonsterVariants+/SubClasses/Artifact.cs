using RoR2;
using R2API;
using UnityEngine;
using System.Collections.Generic;
using RoR2.ContentManagement;
using MonsterVariants.Components;
using MonoMod.RuntimeDetour;
using System.Reflection;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class Artifact
    {
        public static ArtifactDef Variance = ScriptableObject.CreateInstance<ArtifactDef>();
        public static void InitializeArtifact()
        {
            //Sexy, Sexy hook <3
            new Hook(typeof(VariantHandler).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance), typeof(Artifact).GetMethod("MonsterVariantAwakeHook"));
            Variance.nameToken = "Artifact of Variance";
            if (ConfigLoader.ArtifactIncreasesRewards)
            {
                Variance.descriptionToken = "All Variant's Spawn Rates & Rewards are Multiplied by " + ConfigLoader.SpawnRateMultiplier;
            }
            else
            {
                Variance.descriptionToken = "All Variant's Spawn Rates are Multiplied by " + ConfigLoader.SpawnRateMultiplier;
            }
            Variance.smallIconDeselectedSprite = AssetLoaderAndChecker.MainAssets.LoadAsset<Sprite>("Assets/Textures/Artifact/VarianceDisabled.png");
            Variance.smallIconSelectedSprite = AssetLoaderAndChecker.MainAssets.LoadAsset<Sprite>("Assets/Textures/Artifact/VarianceEnabled.png");

            ArtifactAPI.Add(Variance);
        }
        public static void MonsterVariantAwakeHook(Action<VariantHandler> orig, VariantHandler self)
        {
            var origRate = self.spawnRate;
            if (RunArtifactManager.instance.IsArtifactEnabled(Variance))
            {
                self.spawnRate *= ConfigLoader.SpawnRateMultiplier;
                //Avoid potentially bad spawn rates
                if(self.spawnRate < 0)
                {
                    self.spawnRate = 0;
                }
                else if(self.spawnRate > 100)
                {
                    self.spawnRate = 100;
                }
            }
            orig(self);
            self.spawnRate = origRate;
        }
    }
}
