﻿using MV = MonsterVariants.MainPlugin;
using UnityEngine;
using MonsterVariants;
using MonsterVariantsPlus.SubClasses.Skills;
using RoR2.Skills;
using System.Collections.Generic;
using RoR2;

namespace MonsterVariantsPlus.SubClasses
{
    public class CustomVariants
    {
        internal static void RegisterCustomVariants()
        {
            //Gathers vanilla materials
            Material wispFlameMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/WispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[1].defaultMaterial);
            Material wispBodyMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/WispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            //Mosquito Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                overrideName = "Mosquito Wisp",
                spawnRate = ConfigLoader.MosquitoWispSpawnChance.Value ,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 5.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 1.1f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("AlienHead", 5),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Steel Contraption
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bell",
                overrideName = "Steel Contraption",
                spawnRate = ConfigLoader.SteelContraptionSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(1.0f),
                healthMultiplier = 1.75f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 0.75f,
                damageMultiplier = 1.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("SteelContraption")),
                skillReplacement = null
            });
            //Aluminum Contraption
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bell",
                overrideName = "Aluminum Contraption",
                spawnRate = ConfigLoader.AluminumContraptionSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 0.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("AlienHead", 1),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("AluminumContraption")),
                skillReplacement = null,
            });
            //Mortar Crab
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "HermitCrab",
                overrideName = "Mortar Crab",
                spawnRate = ConfigLoader.MortarCrabSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.8f,
                attackSpeedMultiplier = 0.8f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("Behemoth", 1),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Vampiric Templar
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBruiser",
                overrideName = "Vampiric Templar",
                spawnRate = ConfigLoader.VampiricTemplarSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
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
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "MiniMushroom",
                overrideName = "AD-Shroom",
                spawnRate = ConfigLoader.ADShroomSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.75f),
                healthMultiplier = 1.25f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 0.062f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = MV.SimpleInventory("AlienHead", 5),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("ADShroom")),
                skillReplacement = null
            });
            //Healer-Shroom
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "MiniMushroom",
                overrideName = "Healer-Shroom",
                spawnRate = ConfigLoader.HealerShroomSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.5f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 0.5f,
                damageMultiplier = 0.5f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = MV.SimpleInventory("Mushroom", 2),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("HealerShroom")),
                skillReplacement = null,
            });
            //Adolescent
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Parent",
                overrideName = "Adolescent",
                spawnRate = ConfigLoader.AdolescentSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.75f),
                healthMultiplier = 0.75f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.2f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = adolescentInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Child
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Parent",
                overrideName = "Child",
                spawnRate = ConfigLoader.ChildSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 3.0f,
                attackSpeedMultiplier = 6.0f,
                damageMultiplier = 0.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("AlienHead", 1),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = primaryUtilityReplacement(CustomSkills.multiSlamDef, CustomSkills.emptySkillDef)
            });
            //Bruiser Imp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Imp",
                overrideName = "Bruiser Imp",
                spawnRate = ConfigLoader.BruiserImpSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 0.8f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = bruiserInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.UtilityReplacement(CustomSkills.emptySkillDef),
            });
            //Alpha Bison
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bison",
                overrideName = "Alpha Bison",
                spawnRate = ConfigLoader.AlphaBisonSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 0.75f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 0.7f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("Behemoth", 2),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("AlphaBison")),
                skillReplacement = null,
            });
            //Kamikaze Reaver
            /*MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Nullifier",
                overrideName = "Kamikaze Reaver",
                spawnRate = ConfigLoader.KamikazeReaverSpawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.GroundSizeModifier(1.2f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 10.0f,
                attackSpeedMultiplier = 1.2f,
                damageMultiplier = 1,
                armorBonus = 0,
                customInventory = MV.SimpleInventory("HealthDecay", 15),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.PrimaryReplacement(CustomSkills.kamikazeBlinkDef),
            });*/
            //Wisp Amalgamate
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "GreaterWisp",
                overrideName = "Wisp Amalgamate",
                spawnRate = ConfigLoader.WispAmalgamateSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(0.75f),
                healthMultiplier = 1,
                moveSpeedMultiplier = 1,
                attackSpeedMultiplier = 1,
                damageMultiplier = 1,
                armorBonus = 0,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, wispBodyMat}, { 1, wispFlameMat}}),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.WispAmalgamateDef)
            });
            //Sun Priest
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "GrandParent",
                overrideName = "Sun Priest",
                spawnRate = ConfigLoader.SunPriestSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = null,
                healthMultiplier = 1,
                moveSpeedMultiplier = 1,
                attackSpeedMultiplier = 1,
                damageMultiplier = 1,
                armorMultiplier = 1,
                armorBonus = -50,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null,
            });
            //Hoarder
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Scav",
                overrideName = "Hoarder",
                spawnRate = ConfigLoader.HoarderSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.75f),
                healthMultiplier = 0.75f,
                moveSpeedMultiplier = 1.25f,
                attackSpeedMultiplier = 1.25f,
                damageMultiplier = 0.9f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.UtilityReplacement(CustomSkills.hoarderSitDef),
            });
            //Starving Dunestrider
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBoss",
                overrideName = "Starving Dunestrider",
                spawnRate = ConfigLoader.StarvingDunestriderSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = null,
                healthMultiplier = 1,
                moveSpeedMultiplier = 1,
                attackSpeedMultiplier = 1,
                damageMultiplier = 1,
                armorMultiplier = 1,
                armorBonus =-50,
                customInventory = MV.SimpleInventory("AlienHead", 1),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Devourer Dunestrider
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBoss",
                overrideName = "Devourer Dunestrider",
                spawnRate = ConfigLoader.DevourerDunestriderspawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.25f,
                attackSpeedMultiplier = 1.25f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = 0.0f,
                customInventory = devourerInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.SpecialReplacement(CustomSkills.xlRecoverDef),
            });
            //Malfunctioning Solus Control Unit
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "RoboBallBoss",
                overrideName = "Malfunctioning Solus Control Unit",
                spawnRate = ConfigLoader.MalfunctioningSolusControlUnitSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -50f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null,
            });
            //Malfunctioning Alloy Worship Unit
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "SuperRoboBallBoss",
                overrideName = "Malfunctioning Alloy Worship Unit",
                spawnRate = ConfigLoader.MalfunctioningAlloyWorshipUnitSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -50f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null,
            });
            if (MainPlugin.hasClayMan)
            {
                //Clay Soldier
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "MoffeinClayMan",
                    overrideName = "Clay Soldier",
                    spawnRate = ConfigLoader.ClaySoldierSpawnChance.Value,
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(1.125f),
                    healthMultiplier = 1.25f,
                    moveSpeedMultiplier = 0.9f,
                    attackSpeedMultiplier = 1.5f,
                    damageMultiplier = 0.5f,
                    armorMultiplier = 1f,
                    armorBonus = 0f,
                    customInventory = MV.SimpleInventory("AlienHead", 1),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null
                });
            }
            if (MainPlugin.hasAncientWisp)
            {
                //Enraged Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "MoffeinAncientWisp",
                    overrideName = "Enraged Wisp",
                    spawnRate = ConfigLoader.EnragedWispSpawnChance.Value,
                    variantTier = MonsterVariantTier.Common,
                    aiModifier = MonsterVariantAIModifier.Unstable,
                    sizeModifier = null,
                    healthMultiplier = 1,
                    moveSpeedMultiplier = 1,
                    attackSpeedMultiplier = 1,
                    damageMultiplier = 1,
                    armorMultiplier = 1,
                    armorBonus = -50,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                    
                });
            }
            if (ConfigLoader.EnableOtherVariants)
            {
                //Gland - Beetle Guard Brute
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "BeetleGuardAlly",
                    overrideName = "Beetle Guard Brute",
                    spawnRate = ConfigLoader.GlandBeetleGuardBruteSpawnChance.Value,
                    variantTier = MonsterVariantTier.Uncommon,
                    sizeModifier = MV.GroundSizeModifier(1.1f),
                    healthMultiplier = 2f,
                    moveSpeedMultiplier = 0.5f,
                    attackSpeedMultiplier = 0.9f,
                    damageMultiplier = 1.4f,
                    armorMultiplier = 1f,
                    armorBonus = 10f,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });;
                //Gland - Beetle Guard Sharpshooter
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "BeetleGuardAlly",
                    spawnRate = ConfigLoader.GlandBeetleGuardSharpshooterSpawnChance.Value,
                    overrideName = "Beetle Guard Sharpshooter",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(0.8f),
                    healthMultiplier = 0.8f,
                    moveSpeedMultiplier = 0.6f,
                    attackSpeedMultiplier = 3f,
                    damageMultiplier = 0.4f,
                    armorMultiplier = 1f,
                    armorBonus = 0f,
                    customInventory = MV.SimpleInventory("AlienHead", 10),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null
                });
                //Squid Chaingun
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "SquidTurret",
                    spawnRate = ConfigLoader.SquidChaingunSpawnChance.Value,
                    overrideName = "Chaingun Squid",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(0.5f),
                    healthMultiplier = 1f,
                    attackSpeedMultiplier = 5f,
                    damageMultiplier = 0.30f,
                    armorMultiplier = 1f,
                    armorBonus = 0f,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
                //Sniper Squid
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "SquidTurret",
                    spawnRate = ConfigLoader.SquidChaingunSpawnChance.Value,
                    overrideName = "Sniper Squid",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(1.25f),
                    healthMultiplier = 1f,
                    attackSpeedMultiplier = 0.1f,
                    damageMultiplier = 10f,
                    armorMultiplier = 0f,
                    armorBonus = -100f,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
            }
        }
        readonly static ItemInfo[] vampiricInventory = new ItemInfo[]
        {
                MV.SimpleItem("CritGlasses", 10),
                MV.SimpleItem("HealOnCrit", 20),
        };
        readonly static ItemInfo[] bruiserInventory = new ItemInfo[]
        {
            MV.SimpleItem("AlienHead", 5),
            MV.SimpleItem("Crowbar", 2),
        };
        readonly static ItemInfo[] adolescentInventory = new ItemInfo[]
        {
            MV.SimpleItem("ParentEgg", 1),
            MV.SimpleItem("Medkit", 1),
            MV.SimpleItem("UtilitySkillMagazine", 1),
            MV.SimpleItem("AlienHead", 3),
        };
        readonly static ItemInfo[] devourerInventory = new ItemInfo[]
        {
            MV.SimpleItem("RepeatHeal", 2),
            MV.SimpleItem("BarrierOnOverHeal", 2)
        };
        //Method to replace a monster's primary and utility skills. used for Child.
        internal static MonsterSkillReplacement[] primaryUtilityReplacement(SkillDef primarySkill, SkillDef utilitySkill)
        {
            MonsterSkillReplacement primaryReplacement = ScriptableObject.CreateInstance<MonsterSkillReplacement>();
            MonsterSkillReplacement utilityReplacement = ScriptableObject.CreateInstance<MonsterSkillReplacement>();

            primaryReplacement.skillSlot = RoR2.SkillSlot.Primary;
            utilityReplacement.skillSlot = RoR2.SkillSlot.Utility;

            primaryReplacement.skillDef = primarySkill;
            utilityReplacement.skillDef = utilitySkill;

            return new MonsterSkillReplacement[]
            {
                primaryReplacement,
                utilityReplacement
            };
        }
    }
}
