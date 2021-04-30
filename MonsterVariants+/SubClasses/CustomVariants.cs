using MV = MonsterVariants.MainPlugin;
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
            ItemDisplayRuleSet itemDisplayRuleSet = Resources.Load<GameObject>("Prefabs/CharacterBodies/CommandoBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().itemDisplayRuleSet;
            Material wispFlameMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/WispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[1].defaultMaterial);
            Material wispBodyMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/WispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            Material greaterWispFlameMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/GreaterWispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[1].defaultMaterial);
            Material greaterWispBodyMat = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/GreaterWispBody").GetComponentInChildren<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            Material archaicWispBodyMat = Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/ArchWispBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            Material archaicWispFlameMat = Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/ArchWispBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().baseRendererInfos[1].defaultMaterial);
            Material perforatorMat = UnityEngine.Object.Instantiate(itemDisplayRuleSet.FindDisplayRuleGroup(RoR2Content.Items.FireballsOnHit).rules[0].followerPrefab.GetComponentInChildren<MeshRenderer>().material);
            //Leastest Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                overrideName = "Leastest Wisp",
                spawnRate = ConfigLoader.LeastestWispSpawnChance.Value,
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
            //Almost but not quite archaic wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                overrideName = "Almost-But-Not-Quite-Archaic Wisp",
                spawnRate = ConfigLoader.AlmostButNotQuiteArchaicWispSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(1.25f),
                healthMultiplier = 6.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, archaicWispBodyMat }, { 1, archaicWispFlameMat } }),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeArchCannonDef)
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
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("SteelContraption")),
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
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("AluminumContraption")),
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
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("ADShroom")),
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
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("HealerShroom")),
                skillReplacement = null,
            });
            //Mama Shroom
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "MiniMushroom",
                overrideName = "Mama-Mushroom",
                spawnRate = ConfigLoader.MamaShroomSpawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.GroundSizeModifier(2f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 0.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1,
                armorBonus = -50,
                customInventory = MamaInventory,
                meshReplacement = null,
                materialReplacement = null,
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
                skillReplacement = PrimaryUtilityReplacement(CustomSkills.multiSlamDef, CustomSkills.emptySkillDef)
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
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("AlphaBison")),
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
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, wispBodyMat }, { 1, wispFlameMat } }),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.wispAmalgamateDef)
            });
            //Kinda-Great-But-Not-Greater Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "GreaterWisp",
                overrideName = "Kinda-Great-But-Not-Greater Wisp",
                spawnRate = ConfigLoader.KindaGreatButNotGreaterWispSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 5.0f,
                attackSpeedMultiplier = 5.0f,
                damageMultiplier = 1,
                armorBonus = 0,
                armorMultiplier = 1,
                customInventory = MV.SimpleInventory("AlienHead", 2),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Swarmer Probe
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "RoboBallMini",
                overrideName = "Swarmer Probe",
                spawnRate = ConfigLoader.SwarmerProbeSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                sizeModifier = MV.FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 4.0f,
                attackSpeedMultiplier = 4.0f,
                damageMultiplier = 0.3f,
                armorBonus = 0,
                armorMultiplier = 1,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null,
            });
            //Incinerating Elder Lemurian
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "LemurianBruiser",
                overrideName = "Incinerating Elder Lemurian",
                spawnRate = ConfigLoader.IncineratingElderLemurianSpawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.5f,
                attackSpeedMultiplier = 30f,
                damageMultiplier = 7.5f,
                armorBonus = -50,
                customInventory = MV.SimpleInventory("Behemoth", 5),
                meshReplacement  = null,
                materialReplacement = MV.SimpleMaterialReplacement(perforatorMat),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.emptySkillDef)
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
                customInventory = null,
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
                variantTier = MonsterVariantTier.Uncommon,
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
                sizeModifier = MV.FlyingSizeModifier(1.0f),
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
            //Solus Swarming Unit
            /*MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "RoboBallBoss",
                overrideName = "Solus Swarming Unit",
                spawnRate = ConfigLoader.SolusSwarmingUnitSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(0.25f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.2f,
                attackSpeedMultiplier = 1.2f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -100f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.UtilityReplacement(CustomSkills.DeploySwarmDef)
            });*/
            //Malfunctioning Alloy Worship Unit
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "SuperRoboBallBoss",
                overrideName = "Malfunctioning Alloy Worship Unit",
                spawnRate = ConfigLoader.MalfunctioningAlloyWorshipUnitSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = MV.FlyingSizeModifier(1.0f),
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
                //Amalgamated Ancient Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "MoffeinAncientWisp",
                    overrideName = "Amalgamated Ancient Wisp",
                    spawnRate = ConfigLoader.AmalgamatedAncientWispSpawnChance.Value,
                    variantTier = MonsterVariantTier.Uncommon,
                    sizeModifier = MV.FlyingSizeModifier(1.25f),
                    healthMultiplier = 1.25f,
                    moveSpeedMultiplier = 1.2f,
                    attackSpeedMultiplier = 1.1f,
                    damageMultiplier = 1,
                    armorMultiplier = 1,
                    armorBonus = -50,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, greaterWispBodyMat }, { 1, greaterWispFlameMat } }),
                    skillReplacement = null,
                });
            }
            if (MainPlugin.hasArchWisp)
            {
                //Aeonic Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "NebbyArchWisp",
                    overrideName = "Aeonic Wisp",
                    variantTier = MonsterVariantTier.Rare,
                    sizeModifier = MV.FlyingSizeModifier(1.25f),
                    spawnRate = ConfigLoader.AeonicWispSpawnChance.Value,
                    healthMultiplier = 2f,
                    moveSpeedMultiplier = 0.9f,
                    attackSpeedMultiplier = 1.2f,
                    damageMultiplier = 1.0f,
                    armorMultiplier = 1.0f,
                    armorBonus = 20,
                    customInventory = MV.SimpleInventory("AlienHead", 2),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
                //Kinda Archaic Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "NebbyArchWisp",
                    overrideName = "Kinda-Archaic-Wisp",
                    variantTier = MonsterVariantTier.Rare,
                    sizeModifier = MV.FlyingSizeModifier(0.5f),
                    spawnRate = ConfigLoader.KindaArchaicWispSpawnChance.Value,
                    healthMultiplier = 0.5f,
                    moveSpeedMultiplier = 5.0f,
                    attackSpeedMultiplier = 5.0f,
                    damageMultiplier = 1,
                    armorBonus = 0,
                    armorMultiplier = 1,
                    customInventory = MV.SimpleInventory("AlienHead", 2),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null
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
        readonly static ItemInfo[] MamaInventory = new ItemInfo[]
        {
            MV.SimpleItem("Mushroom", 10),
            MV.SimpleItem("BarrierOnOverHeal", 1)
        };
        //Method to replace a monster's primary and utility skills. used for Child.
        internal static MonsterSkillReplacement[] PrimaryUtilityReplacement(SkillDef primarySkill, SkillDef utilitySkill)
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
            //Method to replace a monster's primary and utility skills. used for Child.
        }
        internal static MonsterSkillReplacement[] PrimarySecondarySkillReplacement(SkillDef primarySkill, SkillDef secondarySkill)
        {
            MonsterSkillReplacement primaryReplacement = ScriptableObject.CreateInstance<MonsterSkillReplacement>();
            MonsterSkillReplacement secondaryReplacement = ScriptableObject.CreateInstance<MonsterSkillReplacement>();

            primaryReplacement.skillSlot = RoR2.SkillSlot.Primary;
            secondaryReplacement.skillSlot = RoR2.SkillSlot.Secondary;

            primaryReplacement.skillDef = primarySkill;
            secondaryReplacement.skillDef = secondarySkill;

            return new MonsterSkillReplacement[]
            {
            primaryReplacement,
            secondaryReplacement,
            };
        }
    }
}
