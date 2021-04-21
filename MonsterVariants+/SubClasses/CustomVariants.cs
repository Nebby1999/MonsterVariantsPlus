using MV = MonsterVariants.MainPlugin;
using UnityEngine;
using MonsterVariants;
using MonsterVariantsPlus.SubClasses.Skills;
using RoR2.Skills;

namespace MonsterVariantsPlus.SubClasses
{
    public class CustomVariants
    {
        
        internal static void RegisterCustomVariants()
        {
            //Mosquito Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                spawnRate = ConfigLoader.MosquitoWispSpawnChance,
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
                spawnRate = ConfigLoader.SteelContraptionSpawnChance,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.FlyingSizeModifier(1.0f),
                healthMultiplier = 1.75f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 0.75f,
                damageMultiplier = 1.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("steelContraption")),
                skillReplacement = null
            });
            //Mortar Crab
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "HermitCrab",
                spawnRate = ConfigLoader.MortarCrabSpawnChance,
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
            MonsterVariants.MainPlugin.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBruiser",
                spawnRate = ConfigLoader.VampiricTemplarSpawnChance,
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
                spawnRate = ConfigLoader.ADShroomSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.75f),
                healthMultiplier = 1.25f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 0.062f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("AlienHead", 5),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(MainPlugin.MainAssets.LoadAsset<Material>("ADShroom")),
                skillReplacement = null
            });
            //Adolescent
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Parent",
                spawnRate = ConfigLoader.AdolescentSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.75f),
                healthMultiplier = 0.1f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.2f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = adolescentInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Child
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Parent",
                spawnRate = ConfigLoader.ChildSpawnChance,
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
                spawnRate = ConfigLoader.BruiserImpSpawnChance,
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
                spawnRate = 
            })
            if (MainPlugin.hasClayMan)
            {
                //Clay Soldier
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "MoffeinClayMan",
                    spawnRate = ConfigLoader.ClaySoldierSpawnChance,
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
            MV.SimpleItem("Medkit", 1),
            MV.SimpleItem("UtilitySkillMagazine", 1),
            MV.SimpleItem("AlienHead", 3),
            MV.SimpleItem("NovaOnHeal", 1),
            MV.SimpleItem("PersonalShield", 20)

        };
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
