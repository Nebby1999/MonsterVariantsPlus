﻿
using MonsterVariants.Components;
using UnityEngine;
using MonsterVariants;
using System.Collections.Generic;

namespace MonsterVariantsPlus.SubClasses
{
    public class CustomVariants
    {
        internal static void RegisterCustomVariants()
        {
            //Mosquito Wisp
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                spawnRate = ConfigLoader.MosquitoWispSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 5.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 1.1f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = SimpleInventory("AlienHead", 5),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Steel Contraption
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bell",
                spawnRate = ConfigLoader.SteelContraptionSpawnChance,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = FlyingSizeModifier(1.0f),
                healthMultiplier = 1.75f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 0.75f,
                damageMultiplier = 1.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Mortar Crab
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "HermitCrab",
                spawnRate = ConfigLoader.MortarCrabSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = GroundSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.8f,
                attackSpeedMultiplier = 0.8f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = SimpleInventory("Behemoth", 1),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Vampiric Templar
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBruiser",
                spawnRate = ConfigLoader.VampiricTemplarSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = GroundSizeModifier(1.25f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.25f,
                damageMultiplier = 0.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = vampiricInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //AD-Shroom (Area of Denial Shroom)
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "MiniMushroom",
                spawnRate = ConfigLoader.ADShroomSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = GroundSizeModifier(0.75f),
                healthMultiplier = 1.25f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 0.062f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = SimpleInventory("AlienHead", 5),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
        }
        internal static void AddVariant(MonsterVariantInfo info)
        {
            VariantHandler variantHandler = Resources.Load<GameObject>("prefabs/characterbodies/" + info.bodyName + "Body").AddComponent<VariantHandler>();
            variantHandler.Init(info);

        }

        readonly static ItemInfo[] vampiricInventory = new ItemInfo[]
        {
                SimpleItem("CritGlasses", 10),
                SimpleItem("HealOnCrit", 20),
        };
        internal static ItemInfo[] SimpleInventory(string itemName, int itemCount)
        {
            ItemInfo info = SimpleItem(itemName, itemCount);

            List<ItemInfo> infos = new List<ItemInfo>();

            infos.Add(info);

            ItemInfo[] newInfos = infos.ToArray();

            return newInfos;
        }
        internal static ItemInfo SimpleItem(string itemName, int itemCount)
        {
            ItemInfo info = ScriptableObject.CreateInstance<ItemInfo>();
            info.itemString = itemName;
            info.count = itemCount;

            return info;
        }
        internal static MonsterSizeModifier GroundSizeModifier(float newSize)
        {
            MonsterSizeModifier sizeModifier = ScriptableObject.CreateInstance<MonsterSizeModifier>();
            sizeModifier.newSize = newSize;
            sizeModifier.scaleCollider = false;

            return sizeModifier;
        }
        internal static MonsterSizeModifier FlyingSizeModifier(float newSize)
        {
            MonsterSizeModifier sizeModifier = ScriptableObject.CreateInstance<MonsterSizeModifier>();
            sizeModifier.newSize = newSize;
            sizeModifier.scaleCollider = true;

            return sizeModifier;
        }
        //Steel Contraption Material
        /*internal static CreateMaterials()
        {
            var steelContraptionMaterial = new Material(Shader.Find("hgstandard"));
            steelContraptionMaterial.SetTexture("_MainTex", )
        }*/
    }
}
