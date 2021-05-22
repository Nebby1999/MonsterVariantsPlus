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
            Material stoneGolemMat = Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/GolemBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            Material spectralMat = Resources.Load<Material>("Materials/matGhostEffect");
            Material afterburnerFireMat = Object.Instantiate(Resources.Load<GameObject>("Prefabs/PickupModels/PickupAfterburner").GetComponentInChildren<ParticleSystemRenderer>(true).material);
            Material impOverlord1 = Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/ImpBossBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().baseRendererInfos[0].defaultMaterial);
            Material impOverlord2 = Object.Instantiate(Resources.Load<GameObject>("Prefabs/CharacterBodies/ImpBossBody").GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>().baseRendererInfos[1].defaultMaterial);
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
                healthMultiplier = 5.0f,
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
            //Stone Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                overrideName = "Lesser Stone Wisp",
                spawnRate = ConfigLoader.LesserStoneWispSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(1.5f),
                healthMultiplier = 8.0f,
                moveSpeedMultiplier = 0.75f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1f,
                armorMultiplier = 1.0f,
                armorBonus = 10,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, stoneGolemMat }, { 1, afterburnerFireMat } }),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeWispLaserDef)
            });
            //Steel Contraption
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bell",
                overrideName = "Steel Contraption",
                spawnRate = ConfigLoader.SteelContraptionSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                sizeModifier = MV.FlyingSizeModifier(1.0f),
                healthMultiplier = 1.50f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 0.75f,
                damageMultiplier = 1.5f,
                armorMultiplier = 1f,
                armorBonus = 25f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("SteelContraption")),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.megaBrassBallDef)
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
                damageMultiplier = 0.75f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("AlienHead", 2),
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
                attackSpeedMultiplier = 10.0f,
                damageMultiplier = 0.062f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = ADInventory,
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
                attackSpeedMultiplier = 0.25f,
                damageMultiplier = 0.5f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = MV.SimpleInventory("Mushroom", 5),
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
                healthMultiplier = 2.0f,
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
                damageMultiplier = 1.5f,
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
                damageMultiplier = 1.0f,
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
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 3.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = bruiserInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.UtilityReplacement(CustomSkills.emptySkillDef),
            });
            //Ichor Imp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Imp",
                overrideName = "Ichor Imp",
                spawnRate = ConfigLoader.IchorImpSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = 10,
                customInventory = ichorImpInventory,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("IchorImp")),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.ichorClawsDef)
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
                damageMultiplier = 1.0f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = MV.SimpleInventory("Behemoth", 2),
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("AlphaBison")),
                skillReplacement = null,
            });
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
                attackSpeedMultiplier = 1.5f,
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
                attackSpeedMultiplier = 2.5f,
                damageMultiplier = 1,
                armorBonus = 0,
                armorMultiplier = 1,
                customInventory = MV.SimpleInventory("AlienHead", 2),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Greater Stone Wisp
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "GreaterWisp",
                overrideName = "Greater Stone Wisp",
                spawnRate = ConfigLoader.GreaterStoneWispSpawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.FlyingSizeModifier(1.5f),
                healthMultiplier = 2.5f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = 10,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, stoneGolemMat }, { 1, afterburnerFireMat } }),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeDoubleWispLaserDef),
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
            //Gaussian Probe
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "RoboBallMini",
                overrideName = "Gaussian Probe",
                spawnRate = 100,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.FlyingSizeModifier(1.5f),
                healthMultiplier = 2.0f,
                moveSpeedMultiplier = 0.75f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorBonus = 25,
                armorMultiplier = 1,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.PrimaryReplacement(CustomSkills.gaussianBurstDef),
            });
            //Incinerating Elder Lemurian
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "LemurianBruiser",
                overrideName = "Incinerating Elder Lemurian",
                spawnRate = ConfigLoader.IncineratingElderLemurianSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 30f,
                damageMultiplier = 2.0f,
                armorBonus = -10,
                customInventory = incineratingInventory,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(perforatorMat),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeSingleFireballDef)
            });
            //Ghost of Kjaro
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "LemurianBruiser",
                overrideName = "Ghost of Kjaro",
                spawnRate = ConfigLoader.GhostOfKjaroSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.75f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.5f,
                armorBonus = 0,
                armorMultiplier = 0,
                customInventory = kjaroInventory,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(spectralMat),
                skillReplacement = null,
            });
            //Ghost of Runald
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "LemurianBruiser",
                overrideName = "Ghost of Runald",
                spawnRate = ConfigLoader.GhostOfRunaldSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.5f,
                damageMultiplier = 1.0f,
                armorBonus = 0,
                armorMultiplier = 0,
                customInventory = runaldInventory,
                meshReplacement = null,
                materialReplacement = MV.SimpleMaterialReplacement(spectralMat),
                skillReplacement = null,
            });
            //Ye Old Golem
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Golem",
                overrideName = "Ye Olde Golem",
                spawnRate = ConfigLoader.YeOldeGolemSpawnChance.Value,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = MV.GroundSizeModifier(2.0f),
                healthMultiplier = 2.0f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorBonus = 20,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.SecondaryReplacement(CustomSkills.golemLaserDef),
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
                armorBonus = -50,
                customInventory = MV.SimpleInventory("UtilitySkillMagazine", 1),
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
            //Ancient Stone Titan
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "Titan",
                overrideName = "Ancient Stone Titan",
                spawnRate = ConfigLoader.AncientStoneTitanSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -50,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Ancient Aurelionite
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "TitanGold",
                overrideName = "Ancient Aurelionite",
                spawnRate = ConfigLoader.AncientAurelioniteSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
                aiModifier = MonsterVariantAIModifier.Unstable,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -50,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Aurelionite Colosus
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "TitanGold",
                overrideName = "Aurelionite Colosus",
                spawnRate = ConfigLoader.AurelioniteColosusSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(3.0f),
                healthMultiplier = 3.0f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 2.0f,
                armorMultiplier = 1.0f,
                armorBonus = 50f,
                customInventory = MV.SimpleInventory("AlienHead", 3),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Pygmy Aurelionite
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "TitanGold",
                overrideName = "Pygmy Aurelionite",
                spawnRate = ConfigLoader.PygmyAurelioniteSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(0.3f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 5.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Beetle Matriarch
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "BeetleQueen2",
                overrideName = "Beetle Matriarch",
                spawnRate = ConfigLoader.BeetleMatriarchSpawnChance.Value,
                variantTier = MonsterVariantTier.Common,
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
                skillReplacement = MV.SpecialReplacement(CustomSkills.beetleSwarmDef)
            });
            //Beetle Empress
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "BeetleQueen2",
                overrideName = "Beetle Empress",
                spawnRate = ConfigLoader.BeetleEmpressSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 1.2f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -70,
                customInventory = MV.SimpleInventory("BeetleGland", 2),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.SpecialReplacement(CustomSkills.onlyBeetleSwarmDef),
            });
            //Berserker Overlord
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ImpBoss",
                overrideName = "Berserker Overlord",
                spawnRate = ConfigLoader.BerserkerOverlordSpawnChance.Value,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = MV.GroundSizeModifier(1.25f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = -50,
                customInventory = berserkerInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = MV.PrimaryReplacement(CustomSkills.emptySkillDef),
            });
            //Ichor Overlord
            MV.AddVariant(new MonsterVariantInfo
            {
                bodyName = "ImpBoss",
                overrideName = "Ichor Overlord",
                spawnRate = 100,
                variantTier = MonsterVariantTier.Common,
                sizeModifier = MV.GroundSizeModifier(1.0f),
                healthMultiplier = 1.0f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.0f,
                damageMultiplier = 1.0f,
                armorMultiplier = 1.0f,
                armorBonus = 0, 
                customInventory = ichorOverlordInventory,
                meshReplacement = null,
                materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, impOverlord1 }, { 1, impOverlord2 }, { 2, AssetLoaderAndChecker.MainAssets.LoadAsset<Material>("IchorOverlord") } }),
                skillReplacement = MV.PrimaryReplacement(CustomSkills.fireIchorSpikesDef)
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
                    damageMultiplier = 0.75f,
                    armorMultiplier = 1f,
                    armorBonus = 20f,
                    customInventory = MV.SimpleInventory("AlienHead", 1),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null
                });
                //Clay Assasin
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "MoffeinClayMan",
                    overrideName = "Clay Assasin",
                    spawnRate = ConfigLoader.ClayAssasinSpawnChance.Value,
                    variantTier = MonsterVariantTier.Uncommon,
                    sizeModifier = MV.GroundSizeModifier(0.75f),
                    healthMultiplier = 1.0f,
                    moveSpeedMultiplier = 1.2f,
                    attackSpeedMultiplier = 1.0f,
                    damageMultiplier = 1.0f,
                    armorMultiplier = 1f,
                    armorBonus = -25f,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, spectralMat }, { 1, spectralMat }, { 2, spectralMat } }),
                    skillReplacement = null,
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
                    materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, greaterWispBodyMat }, { 3, greaterWispFlameMat }, { 4, wispFlameMat } }),
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
                    variantTier = MonsterVariantTier.Uncommon,
                    sizeModifier = MV.FlyingSizeModifier(1.25f),
                    spawnRate = ConfigLoader.AeonicWispSpawnChance.Value,
                    healthMultiplier = 1.5f,
                    moveSpeedMultiplier = 0.75f,
                    attackSpeedMultiplier = 0.9f,
                    damageMultiplier = 1.0f,
                    armorMultiplier = 1.0f,
                    armorBonus = 20,
                    customInventory = MV.SimpleInventory("Behemoth", 1),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
                //Kinda Archaic Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "NebbyArchWisp",
                    overrideName = "Kinda-Archaic Wisp",
                    variantTier = MonsterVariantTier.Uncommon,
                    sizeModifier = MV.FlyingSizeModifier(0.5f),
                    spawnRate = ConfigLoader.KindaArchaicWispSpawnChance.Value,
                    healthMultiplier = 0.5f,
                    moveSpeedMultiplier = 5.0f,
                    attackSpeedMultiplier = 2.5f,
                    damageMultiplier = 1,
                    armorBonus = 0,
                    armorMultiplier = 1,
                    customInventory = MV.SimpleInventory("AlienHead", 2),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null
                });
                //Archaic Stone Wisp
                MV.AddModdedVariant(new MonsterVariantInfo
                {
                    bodyName = "NebbyArchWisp",
                    overrideName = "Archaic Stone Wisp",
                    variantTier = MonsterVariantTier.Rare,
                    sizeModifier = MV.FlyingSizeModifier(1.5f),
                    spawnRate = ConfigLoader.ArchaicStoneWispSpawnChance.Value,
                    healthMultiplier = 2.0f,
                    moveSpeedMultiplier = 0.5f,
                    attackSpeedMultiplier = 1.0f,
                    damageMultiplier = 1,
                    armorBonus = 10,
                    armorMultiplier = 1,
                    customInventory = null,
                    meshReplacement = null,
                    materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, perforatorMat }, { 1, afterburnerFireMat } }),
                    skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeMegaWispLaserDef)
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
                }); ;
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
                //Lunar Squid
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "SquidTurret",
                    spawnRate = ConfigLoader.LunarSquidSpawnChance.Value,
                    overrideName = "Lunar Squid",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(1.0f),
                    healthMultiplier = 1f,
                    attackSpeedMultiplier = 1f,
                    damageMultiplier = 1.5f,
                    armorMultiplier = 0f,
                    armorBonus = 0,
                    customInventory = MV.SimpleInventory("LunarPrimaryReplacement", 1),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
                //Time Bomb Squid
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "SquidTurret",
                    spawnRate = ConfigLoader.TimeBombSquidSpawnChance.Value,
                    overrideName = "Time Bomb Squid",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(0.6f),
                    healthMultiplier = 1f,
                    attackSpeedMultiplier = 1f,
                    damageMultiplier = 1.5f,
                    armorMultiplier = 0f,
                    armorBonus = 0,
                    customInventory = MV.SimpleInventory("NovaOnLowHealth", 1),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = MV.PrimaryReplacement(CustomSkills.emptySkillDef),
                });
                //Cannon Squid
                MV.AddVariant(new MonsterVariantInfo
                {
                    bodyName = "SquidTurret",
                    spawnRate = ConfigLoader.CannonSquidSpawnChance.Value,
                    overrideName = "Cannon Squid",
                    variantTier = MonsterVariantTier.Common,
                    sizeModifier = MV.GroundSizeModifier(1.5f),
                    healthMultiplier = 1f,
                    attackSpeedMultiplier = 0.25f,
                    damageMultiplier = 2.5f,
                    armorMultiplier = 0f,
                    armorBonus = 0,
                    customInventory = MV.SimpleInventory("Behemoth", 2),
                    meshReplacement = null,
                    materialReplacement = null,
                    skillReplacement = null,
                });
                if (MainPlugin.hasMysticItems)
                {
                    //Aeonic Wisp
                    MV.AddModdedVariant(new MonsterVariantInfo
                    {
                        bodyName = "ArchWisp",
                        overrideName = "Aeonic Wisp",
                        variantTier = MonsterVariantTier.Uncommon,
                        sizeModifier = MV.FlyingSizeModifier(1.25f),
                        spawnRate = ConfigLoader.AeonicWispSpawnChance.Value,
                        healthMultiplier = 1.5f,
                        moveSpeedMultiplier = 0.75f,
                        attackSpeedMultiplier = 0.9f,
                        damageMultiplier = 1.0f,
                        armorMultiplier = 1.0f,
                        armorBonus = 20,
                        customInventory = MV.SimpleInventory("Behemoth", 1),
                        meshReplacement = null,
                        materialReplacement = null,
                        skillReplacement = null,
                    });
                    //Kinda Archaic Wisp
                    MV.AddModdedVariant(new MonsterVariantInfo
                    {
                        bodyName = "ArchWisp",
                        overrideName = "Kinda-Archaic Wisp",
                        variantTier = MonsterVariantTier.Uncommon,
                        sizeModifier = MV.FlyingSizeModifier(0.5f),
                        spawnRate = ConfigLoader.KindaArchaicWispSpawnChance.Value,
                        healthMultiplier = 0.5f,
                        moveSpeedMultiplier = 5.0f,
                        attackSpeedMultiplier = 2.5f,
                        damageMultiplier = 1,
                        armorBonus = 0,
                        armorMultiplier = 1,
                        customInventory = MV.SimpleInventory("AlienHead", 2),
                        meshReplacement = null,
                        materialReplacement = null,
                        skillReplacement = null
                    });
                    //Archaic Stone Wisp
                    MV.AddModdedVariant(new MonsterVariantInfo
                    {
                        bodyName = "ArchWisp",
                        overrideName = "Archaic Stone Wisp",
                        variantTier = MonsterVariantTier.Rare,
                        sizeModifier = MV.FlyingSizeModifier(1.5f),
                        spawnRate = ConfigLoader.ArchaicStoneWispSpawnChance.Value,
                        healthMultiplier = 2.0f,
                        moveSpeedMultiplier = 0.5f,
                        attackSpeedMultiplier = 1.0f,
                        damageMultiplier = 1,
                        armorBonus = 10,
                        armorMultiplier = 1,
                        customInventory = null,
                        meshReplacement = null,
                        materialReplacement = MV.MultiMaterialReplacement(new Dictionary<int, Material> { { 0, archaicWispBodyMat }, { 1, afterburnerFireMat } }),
                        skillReplacement = MV.PrimaryReplacement(CustomSkills.chargeMegaWispLaserDef)
                    });
                }
            }
        }
        private static readonly ItemInfo[] vampiricInventory = new ItemInfo[]
        {
                MV.SimpleItem("CritGlasses", 10),
                MV.SimpleItem("HealOnCrit", 20),
                MV.SimpleItem("RepeatHeal", 1)
        };
        private static readonly ItemInfo[] bruiserInventory = new ItemInfo[]
        {
            MV.SimpleItem("AlienHead", 5),
            MV.SimpleItem("Crowbar", 3),
        };
        private static readonly ItemInfo[] adolescentInventory = new ItemInfo[]
        {
            MV.SimpleItem("ParentEgg", 1),
            MV.SimpleItem("Medkit", 1),
            MV.SimpleItem("UtilitySkillMagazine", 1),
            MV.SimpleItem("AlienHead", 3),
        };
        private static readonly ItemInfo[] devourerInventory = new ItemInfo[]
        {
            MV.SimpleItem("RepeatHeal", 2),
            MV.SimpleItem("BarrierOnOverHeal", 2),
            MV.SimpleItem("NearbyDamageBonus", 7)
        };
        private static readonly ItemInfo[] MamaInventory = new ItemInfo[]
        {
            MV.SimpleItem("Mushroom", 10),
            MV.SimpleItem("BarrierOnOverHeal", 1),
        };

        private static readonly ItemInfo[] ADInventory = new ItemInfo[]
        {
            MV.SimpleItem("AlienHead", 10),
            MV.SimpleItem("ArmorReductionOnHit", 1)
        };

        private static readonly ItemInfo[] kjaroInventory = new ItemInfo[]
        {
            MV.SimpleItem("FireRing", 3),
            MV.SimpleItem("Phasing", 5),
        };

        private static readonly ItemInfo[] runaldInventory = new ItemInfo[]
        {
            MV.SimpleItem("IceRing", 3),
            MV.SimpleItem("Phasing", 5),
        };

        private static readonly ItemInfo[] ichorImpInventory = new ItemInfo[]
        {
            MV.SimpleItem("BleedOnHit", 17),
            MV.SimpleItem("ITEM_MVP_PULVERIZE_ON_HIT", 1)
        };

        private static readonly ItemInfo[] incineratingInventory = new ItemInfo[]
        {
            MV.SimpleItem("Behemoth", 2),
            MV.SimpleItem("NearbyDamageBonus", 20)
        };

        private static readonly ItemInfo[] berserkerInventory = new ItemInfo[]
        {
            MV.SimpleItem("AlienHead", 2),
            MV.SimpleItem("SecondarySkillMagazine", 2)
        };
        private static readonly ItemInfo[] ichorOverlordInventory = new ItemInfo[]
{
            MV.SimpleItem("BleedOnHit", 5),
            MV.SimpleItem("ITEM_MVP_PULVERIZE_ON_HIT", 1)
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
