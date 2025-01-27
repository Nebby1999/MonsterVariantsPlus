﻿using BepInEx.Configuration;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public static class ConfigLoader
    {
        //Main Categories
        internal static ConfigEntry<bool> EnableItemRewardsConfig { get; set; } //This creates the configuration entry.
        public static bool EnableItemRewards => EnableItemRewardsConfig.Value; //This works as a Get, must keep in mind that "EnableItemRewards" is what one should get if you want to obtain a certain config's Value!
        internal static ConfigEntry<bool> EnableGoldRewardsConfig { get; set; }
        public static bool EnableGoldRewards => EnableGoldRewardsConfig.Value;
        internal static ConfigEntry<bool> EnableXPRewardsConfig { get; set; }
        public static bool EnableXPRewards => EnableXPRewardsConfig.Value;
        internal static ConfigEntry<bool> EnableCustomVariantsConfig { get; set; }
        public static bool EnableCustomVariants => EnableCustomVariantsConfig.Value;
        internal static ConfigEntry<bool> EnableOtherVariantsConfig { get; set; }
        public static bool EnableOtherVariants => EnableOtherVariantsConfig.Value;
        internal static ConfigEntry<bool> EnableConfigCheckConfig { get; set; }
        public static bool EnableConfigcheck => EnableConfigCheckConfig.Value;
        internal static ConfigEntry<bool> EnableArtifactOfVarianceConfig { get; set; }
        public static bool EnableArtifactOfVariance => EnableArtifactOfVarianceConfig.Value;

        //Item Related Configs
        internal static ConfigEntry<bool> ItemSpawnsOnPlayerConfig { get; set; }
        public static bool ItemSpawnsOnPlayer => ItemSpawnsOnPlayerConfig.Value;
        internal static ConfigEntry<string> HiddenRealmItemdropBehaviorConfig { get; set; }
        public static string HiddenRealmItemdropBehavior => HiddenRealmItemdropBehaviorConfig.Value;
        internal static ConfigEntry<int> CommonWhiteChanceConfig { get; set; }
        public static int CommonWhiteChance => CommonWhiteChanceConfig.Value;
        internal static ConfigEntry<int> CommonGreenChanceConfig { get; set; }
        public static int CommonGreenChance => CommonGreenChanceConfig.Value;
        internal static ConfigEntry<int> CommonRedChanceConfig { get; set; }
        public static int CommonRedChance => CommonRedChanceConfig.Value;
        internal static ConfigEntry<int> UncommonWhiteChanceConfig { get; set; }
        public static int UncommonWhiteChance => UncommonWhiteChanceConfig.Value;
        internal static ConfigEntry<int> UncommonGreenChanceConfig { get; set; }
        public static int UncommonGreenChance => UncommonGreenChanceConfig.Value;
        internal static ConfigEntry<int> UncommonRedChanceConfig { get; set; }
        public static int UncommonRedChance => UncommonRedChanceConfig.Value;
        internal static ConfigEntry<int> RareWhiteChanceConfig { get; set; }
        public static int RareWhiteChance => RareWhiteChanceConfig.Value;
        internal static ConfigEntry<int> RareGreenChanceConfig { get; set; }
        public static int RareGreenChance => RareGreenChanceConfig.Value;
        internal static ConfigEntry<int> RareRedChanceConfig { get; set; }
        public static int RareRedChance => RareRedChanceConfig.Value;

        //Money Related Configs
        internal static ConfigEntry<float> CommonMoneyMultConfig { get; set; }
        public static float CommonMoneyMult => CommonMoneyMultConfig.Value;
        internal static ConfigEntry<float> UncommonMoneyMultConfig { get; set; }
        public static float UncommonMoneyMult => UncommonMoneyMultConfig.Value;
        internal static ConfigEntry<float> RareMoneyMultConfig { get; set; }
        public static float RareMoneyMult => RareMoneyMultConfig.Value;

        //XP Related Configs
        internal static ConfigEntry<float> CommonXPMultConfig { get; set; }
        public static float CommonXPMult => CommonXPMultConfig.Value;
        internal static ConfigEntry<float> UncommonXPMultConfig { get; set; }
        public static float UncommonXPMult => UncommonXPMultConfig.Value;
        internal static ConfigEntry<float> RareXPMultConfig { get; set; }
        public static float RareXPMult => RareXPMultConfig.Value;

        //Artifact related configs
        internal static ConfigEntry<float> SpawnRateMultiplierConfig { get; set; }
        public static float SpawnRateMultiplier => SpawnRateMultiplierConfig.Value;
        internal static ConfigEntry<bool> ArtifactIncreasesRewardsConfig { get; set; }
        public static bool ArtifactIncreasesRewards => ArtifactIncreasesRewardsConfig.Value;
        internal static ConfigEntry<bool> ArtifactDecreasesRewardsConfig { get; set; }
        public static bool ArtifactDecreasesRewards => ArtifactDecreasesRewardsConfig.Value;

        //Custom Variants
        internal static ConfigEntry<bool> CertainVariantsSpawnMoreEnemiesConfig { get; set; }
        public static bool CertainVariantsSpawnMoreEnemies => CertainVariantsSpawnMoreEnemiesConfig.Value;
        //Enemy Variants
        public static ConfigEntry<float> LeastestWispSpawnChance;
        public static ConfigEntry<float> AlmostButNotQuiteArchaicWispSpawnChance;
        public static ConfigEntry<float> LesserStoneWispSpawnChance;
        public static ConfigEntry<float> SteelContraptionSpawnChance;
        public static ConfigEntry<float> AluminumContraptionSpawnChance;
        public static ConfigEntry<float> MortarCrabSpawnChance;
        public static ConfigEntry<float> VampiricTemplarSpawnChance;
        public static ConfigEntry<float> ADShroomSpawnChance;
        public static ConfigEntry<float> HealerShroomSpawnChance;
        public static ConfigEntry<float> MamaShroomSpawnChance;
        public static ConfigEntry<float> AdolescentSpawnChance;
        public static ConfigEntry<float> ChildSpawnChance;
        public static ConfigEntry<float> BruiserImpSpawnChance;
        public static ConfigEntry<float> IchorImpSpawnChance;
        public static ConfigEntry<float> AlphaBisonSpawnChance;
        public static ConfigEntry<float> WispAmalgamateSpawnChance;
        public static ConfigEntry<float> KindaGreatButNotGreaterWispSpawnChance;
        public static ConfigEntry<float> GreaterStoneWispSpawnChance;
        public static ConfigEntry<float> SwarmerProbeSpawnChance;
        public static ConfigEntry<float> GaussianProbeSpawnChance;
        public static ConfigEntry<float> SolusProbeMK2SpawnChance;
        public static ConfigEntry<float> IncineratingElderLemurianSpawnChance;
        public static ConfigEntry<float> GhostOfKjaroSpawnChance;
        public static ConfigEntry<float> GhostOfRunaldSpawnChance;
        public static ConfigEntry<float> YeOldeGolemSpawnChance;
        //Boss Variants
        public static ConfigEntry<float> SunPriestSpawnChance;
        public static ConfigEntry<float> HoarderSpawnChance;
        public static ConfigEntry<float> StarvingDunestriderSpawnChance;
        public static ConfigEntry<float> DevourerDunestriderspawnChance;
        public static ConfigEntry<float> MalfunctioningSolusControlUnitSpawnChance;
        //public static ConfigEntry<float> SolusSwarmingUnitSpawnChance;
        public static ConfigEntry<float> MalfunctioningAlloyWorshipUnitSpawnChance;
        //public static ConfigEntry<float> AlloySwarmingUnitSpawnChance;
        public static ConfigEntry<float> AncientStoneTitanSpawnChance;
        public static ConfigEntry<float> AncientAurelioniteSpawnChance;
        public static ConfigEntry<float> AurelioniteColosusSpawnChance;
        public static ConfigEntry<float> PygmyAurelioniteSpawnChance;
        public static ConfigEntry<float> BeetleMatriarchSpawnChance;
        public static ConfigEntry<float> BeetleEmpressSpawnChance;
        public static ConfigEntry<float> BerserkerOverlordSpawnChance;
        public static ConfigEntry<float> IchorOverlordSpawnChance;

        //Modded Variants
        public static ConfigEntry<float> ClaySoldierSpawnChance;
        public static ConfigEntry<float> ClayAssasinSpawnChance;
        public static ConfigEntry<float> EnragedWispSpawnChance;
        public static ConfigEntry<float> AmalgamatedAncientWispSpawnChance;
        public static ConfigEntry<float> AeonicWispSpawnChance;
        public static ConfigEntry<float> KindaArchaicWispSpawnChance;
        public static ConfigEntry<float> ArchaicStoneWispSpawnChance;

        //Other Variants
        public static ConfigEntry<float> GlandBeetleGuardBruteSpawnChance;
        public static ConfigEntry<float> GlandBeetleGuardSharpshooterSpawnChance;
        public static ConfigEntry<float> SquidChaingunSpawnChance;
        public static ConfigEntry<float> SquidSniperSpawnChance;
        public static ConfigEntry<float> LunarSquidSpawnChance;
        public static ConfigEntry<float> TimeBombSquidSpawnChance;
        public static ConfigEntry<float> CannonSquidSpawnChance;
        public static ConfigEntry<float> RECSwarmerProbeSpawnChance;
        public static ConfigEntry<float> RECGaussianProbeSpawnChance;
        public static ConfigEntry<float> RECSolusProbeMK2SpawnChance;
        public static ConfigEntry<float> GECSwarmerProbeSpawnChance;
        public static ConfigEntry<float> GECGaussianProbeSpawnChance;
        public static ConfigEntry<float> GECSolusProbeMK2SpawnChance;
        public static ConfigEntry<float> MIAeonicWispSpawnChance;
        public static ConfigEntry<float> MIKindaArchaicWispSpawnChance;
        public static ConfigEntry<float> MIArchaicStoneWispSpawnChance;

        public static void SetupConfigLoader(ConfigFile config) //Creates the description and some mumbojumbo for the values.
        {
            EnableConfigCheckConfig = config.Bind<bool>("0 - Config Checker", "Enable Config Checker", true, "When set to true, the mod will scan it's config file every time the game begins to check for errors\nErrors include invalid values in the config, such as drop chances being over 100 or below 0.");
            EnableItemRewardsConfig = config.Bind<bool>("1 - Item Rewards", "Enable Item Rewards", true, "If this is set to True, then Enemy Variants have a chance to drop Items. If this is set to False,\nthen the rest of the available options in this category are disabled.");
            EnableGoldRewardsConfig = config.Bind<bool>("2 - Gold Rewards", "Enable Gold Rewards", true, "If this is set to True, then Enemy Variants will drop extra gold based off a multiplier.\nIf this is set to False, then the rest of the available options of this category are disabled.");
            EnableXPRewardsConfig = config.Bind<bool>("3 - XP Rewards", "Enable XP Rewards", true, "If this is set to True, then Enemy Variants will drop extra XP based off a multiplier.\nIf this is set to False, then the rest of the available options of this category are disabled.");
            EnableCustomVariantsConfig = config.Bind<bool>("4 - Custom Variants", "Enable Custom Variants", true, "If this is set to True, then new Enemy Variants designed by nebby will begin spawning, all the effects of killing a regular variant also apply to these.\nIf this is set to False, then the rest of the available options in this category are disabled.");
            EnableOtherVariantsConfig = config.Bind<bool>("5 - Other Variants", "Enable Other Variants", true, "If this is set to True, then living entities other than enemies will get variants, examples include the Queen's Gland's Beetle Guards\nVariants in this category will not spawn rewards if theyre in your Team! (AKA The sidebar with the health bars.)\nIf this is set to false, then the rest of the available options of this category are disabled.");
            EnableArtifactOfVarianceConfig = config.Bind<bool>("6 - Artifact of Variance", "Enable Artifact of Variance", true, "If this is set to True, then the Artifact of Variance is Enabled\nThe artifact of variance multiplies the SpawnRates of ALL Variants by a certain number.\nIf this is ser to false, then the rest of the available options in this category are disabled.");
            CertainVariantsSpawnMoreEnemiesConfig = config.Bind<bool>("4 - Custom Variants", "Do Certain Variants Spawn More Enemies", true, "When this is set to true, certain variants such as the M.O.A.J. & the wisp amalgamate will have the ability to spawn more enemies on death.\n disable in case these variants cause large framedrops when they die.");

            ItemSpawnsOnPlayerConfig = config.Bind<bool>("1 - Item Rewards", "Item Rewards Spawns on Player", false, "Normally the item reward's droplet spawns from the center of the slain Variant.\nThis can cause some issues with killing Variants that are on top of the death plane, or get knocked back onto it, Since the item will be lost in the process.\nSetting this to True causes all Item Rewards to be spawned at the center of the Player who killed the variant.");
            HiddenRealmItemdropBehaviorConfig = config.Bind<string>("1 - Item Rewards", "Item Rewards Hidden Realm Behavior", "Unchanged", "How the item rewards module handles item rewards on hidden realms.\n3 Accepted values, ranging from 'Unchanged', 'Halved', and 'Never'.\nUnchanged: No changes are made. item drop rates are the same as they are in normal stages.\nHalved: Item drop rates are lowered by 50%.\nNever: Enemy Variants never drop items in hidden realms.");
            //HiddenRealmItemdropBehaviorConfig = config.Bind<string>("1 - Item Rewards", "Item Reward's Hidden Realm Behavior", "Halved", "How the item rewards module handles item rewards on hidden realms.\n3 Accepted values, ranging from 'Unchanged', 'Halved', and 'Never'.\nUnchanged: No changes are made to item drop rates are the same as they are in normal stages.\nHalved: Item drop rates are lowered by 50%.\nNever: Enemy Variants never drop items in hidden realms.");

            CommonWhiteChanceConfig = config.Bind<int>("1 - Item Rewards", "Common Variant White Item Drop Chance", 3, "The chance that a Common variant drops a White item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            CommonGreenChanceConfig = config.Bind<int>("1 - Item Rewards", "Common Variant Green Item Drop Chance", 0, "The chance that a Common variant drops a Green item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            CommonRedChanceConfig = config.Bind<int>("1 - Item Rewards", "Common Variant Red Item Drop Chance", 0, "The chance that a Common variant drops a Red item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            UncommonWhiteChanceConfig = config.Bind<int>("1 - Item Rewards", "Uncommon Variant White Item Drop Chance", 5, "The chance that an Uncommon variant drops a White Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            UncommonGreenChanceConfig = config.Bind<int>("1 - Item Rewards", "Uncommon Variant Green Item Drop Chance", 1, "The chance that an Uncommon variant drops a Green Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            UncommonRedChanceConfig = config.Bind<int>("1 - Item Rewards", "Uncommon Variant Red Item Drop Chance", 0, "The chance that an Uncommon variant drops a Red Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            RareWhiteChanceConfig = config.Bind<int>("1 - Item Rewards", "Rare Variant White Item Drop Chance", 10, "The chance that a Rare variant drops a White Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            RareGreenChanceConfig = config.Bind<int>("1 - Item Rewards", "Rare Variant Green Item Drop Chance", 5, "The chance that a Rare variant drops a Green Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            RareRedChanceConfig = config.Bind<int>("1 - Item Rewards", "Rare Variant Red Item Drop Chance", 1, "The chance that a Rare variant drops a Red Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            CommonMoneyMultConfig = config.Bind<float>("2 - Gold Rewards", "Common Variant Gold Multiplier", 1.3f, "Multiplier that's applied to the Gold reward for killing a common Variant.\n(Set this value to 1.0 to disable).");
            UncommonMoneyMultConfig = config.Bind<float>("2 - Gold Rewards", "Uncommon Variant Gold Multiplier", 1.6f, "Multiplier that's applied to the Gold reward for killing an uncommon Variant.\n(Set this value to 1.0 to disable).");
            RareMoneyMultConfig = config.Bind<float>("2 - Gold Rewards", "Rare Variant Gold Multiplier", 2.0f, "Multiplier that's applied to the Gold reward for killing a rare Variant.\n(Set this value to 1.0 to disable).");

            CommonXPMultConfig = config.Bind<float>("3 - XP Rewards", "Common Variant XP Multiplier", 1.3f, "Multiplier that's applied to the XP reward for killing a common Variant.\n(Set this value to 1.0 to disable).");
            UncommonXPMultConfig = config.Bind<float>("3 - XP Rewards", "Uncommon Variant XP Multiplier", 1.6f, "Multiplier that's applied to the XP reward for killing an uncommon Variant.\n(Set this value to 1.0 to disable).");
            RareXPMultConfig = config.Bind<float>("3 - XP Rewards", "Rare Variant XP Multiplier", 2.0f, "Multiplier that's applied to the XP reward for killing a rare Variant.\n(Set this value to 1.0 to disable).");

            SpawnRateMultiplierConfig = config.Bind<float>("6 - Artifact of Variance", "Variant Spawn Rate Multiplier", 2, "Multiplier that's applied to each Variant's spawn rate when the Artifact of Variance is enabled\nIf a variant's Spawn Rate reaches a number higher than 100, it'll be automatically set to 100\nIf a Variant's Spawn Rate reaches a number lower than 0, it'll be automatically set to 0.");
            ArtifactIncreasesRewardsConfig = config.Bind<bool>("6 - Artifact of Variance", "Artifact of Variance Increases Rewards", false, "If this is set to true, then the Artifact of Variance's 'Spawn Rate Multiplier' will also be applied to XP, Gold and Item Rewards.");
        }
        public static void ReadConfig(ConfigFile config)
        {
            LeastestWispSpawnChance = SpawnRateConfig(false, "Leastest Wisp", 7, config);
            AlmostButNotQuiteArchaicWispSpawnChance = SpawnRateConfig(false, "Almost-But-Not-Quite-Archaic-Wisp", 4, config);
            LesserStoneWispSpawnChance = SpawnRateConfig(false, "Lesser Stone Wisp", 2, config);
            SteelContraptionSpawnChance = SpawnRateConfig(false, "Steel Contraption", 7, config);
            AluminumContraptionSpawnChance = SpawnRateConfig(false,"Aluminum Contraption", 7, config);
            MortarCrabSpawnChance = SpawnRateConfig(false, "Mortar Crab", 5, config);
            VampiricTemplarSpawnChance = SpawnRateConfig(false, "Vampiric Templar", 5, config);
            ADShroomSpawnChance = SpawnRateConfig(false, "AD-Shroom (Area of Denial Shroom)", 5, config);
            HealerShroomSpawnChance = SpawnRateConfig(false, "Healer Shroom", 10, config);
            MamaShroomSpawnChance = SpawnRateConfig(false, "Mama Shroom", 2, config);
            AdolescentSpawnChance = SpawnRateConfig(false, "Adolescent", 8, config);
            ChildSpawnChance = SpawnRateConfig(false, "Child", 6, config);
            BruiserImpSpawnChance = SpawnRateConfig(false, "Bruiser Imp", 10, config);
            IchorImpSpawnChance = SpawnRateConfig(false, "Ichor Imp", 5, config);
            AlphaBisonSpawnChance = SpawnRateConfig(false, "Alpha Bison", 5, config);
            WispAmalgamateSpawnChance = SpawnRateConfig(false, "Wisp Amalgamate", 8, config);
            KindaGreatButNotGreaterWispSpawnChance = SpawnRateConfig(false, "Kinda-Great-But-Not-Greater Wisp", 6, config);
            GreaterStoneWispSpawnChance = SpawnRateConfig(false, "Greater Stone Wisp", 2, config);
            SwarmerProbeSpawnChance = SpawnRateConfig(false, "Swarmer Probe", 7, config);
            GaussianProbeSpawnChance = SpawnRateConfig(false, "Gaussian Probe", 10, config);
            SolusProbeMK2SpawnChance = SpawnRateConfig(false, "Solus Probe MK2", 5, config);
            IncineratingElderLemurianSpawnChance = SpawnRateConfig(false, "Incinerating Elder Lemurian", 5, config);
            GhostOfKjaroSpawnChance = SpawnRateConfig(false, "Ghost of Kjaro", 4, config);
            GhostOfRunaldSpawnChance = SpawnRateConfig(false, "Ghost of Runald", 4, config);
            YeOldeGolemSpawnChance = SpawnRateConfig(false, "Ye Olde Golem", 3, config);
            
            //Bosses
            SunPriestSpawnChance = SpawnRateConfig(false, "Sun Priest", 4, config);
            HoarderSpawnChance = SpawnRateConfig(false, "Hoarder", 8, config);
            StarvingDunestriderSpawnChance = SpawnRateConfig(false, "Starving Dunestrider", 4, config);
            DevourerDunestriderspawnChance = SpawnRateConfig(false, "Devourer Dunestrider", 2, config);
            MalfunctioningSolusControlUnitSpawnChance = SpawnRateConfig(false, "Malfunctioning Solus Control Unit", 4, config);
            //SolusSwarmingUnitSpawnChance = SpawnRateConfig(false, "Solus Swarming Unit", 100, config);
            MalfunctioningAlloyWorshipUnitSpawnChance = SpawnRateConfig(false, "Malfunctioning Alloy Worship Unit", 4, config);
            //AlloySwarmingUnitSpawnChance = SpawnRateConfig(false, "Alloy Swarming Unit", 100, config);
            AncientStoneTitanSpawnChance = SpawnRateConfig(false, "Ancient Stone Titan", 4, config);
            AncientAurelioniteSpawnChance = SpawnRateConfig(false, "Ancient Aurelionite", 4, config);
            AurelioniteColosusSpawnChance = SpawnRateConfig(false, "Aurelionite Colosus", 2, config);
            PygmyAurelioniteSpawnChance = SpawnRateConfig(false, "Pygmy Aurelionite", 2, config);
            BeetleMatriarchSpawnChance = SpawnRateConfig(false, "Beetle Matriarch", 4, config);
            BeetleEmpressSpawnChance = SpawnRateConfig(false, "Beetle Empress", 2, config);
            IchorOverlordSpawnChance = SpawnRateConfig(false, "Ichor Overlord Spawn Chance", 4, config);
            BerserkerOverlordSpawnChance = SpawnRateConfig(false, "Berserker Overlord", 2, config);

            //Modded
            ClaySoldierSpawnChance = SpawnRateConfig(false, "Clay Soldier", 15, "Moffein", "ClayMen", config);
            ClayAssasinSpawnChance = SpawnRateConfig(false, "Clay Assasin", 4, "Moffein", "ClayMen", config);
            EnragedWispSpawnChance = SpawnRateConfig(false, "Enraged Wisp", 4, "Moffein", "AncientWisp", config);
            AmalgamatedAncientWispSpawnChance = SpawnRateConfig(false, "Amalgamated Ancient Wisp", 2, "Moffein", "AncientWisp", config);
            AeonicWispSpawnChance = SpawnRateConfig(false, "Aeonic Wisp", 4, "Nebby", "ArchaicWisp", config);
            KindaArchaicWispSpawnChance = SpawnRateConfig(false, "Kinda-Archaic-Wisp", 7, "Nebby", "ArchaicWisp", config);
            ArchaicStoneWispSpawnChance = SpawnRateConfig(false, "Archaic Stone Wisp", 2, "Nebby", "ArchaicWisp", config);

            //Other Variants
            GlandBeetleGuardBruteSpawnChance = SpawnRateConfig(true, "Beetle Guard Brute - Gland", 25, config);
            GlandBeetleGuardSharpshooterSpawnChance = SpawnRateConfig(true, "Beetle Guard Sharpshooter - Gland", 2, config);
            SquidChaingunSpawnChance = SpawnRateConfig(true, "Squid Chaingun", 10, config);
            SquidSniperSpawnChance = SpawnRateConfig(true, "Squid Sniper", 2, config);
            LunarSquidSpawnChance = SpawnRateConfig(true, "Lunar Squid", 4, config);
            TimeBombSquidSpawnChance = SpawnRateConfig(true, "Time Bomb Squid", 2, config);
            CannonSquidSpawnChance = SpawnRateConfig(true, "Cannon Squid", 3, config);
            RECSwarmerProbeSpawnChance = SpawnRateConfig(true, "Red Empathy Core Swarmer Probe Spawn Chance", 7, config);
            RECGaussianProbeSpawnChance = SpawnRateConfig(true, "Red Empathy Core Gaussian Probe Spawn Chance", 10, config);
            RECSolusProbeMK2SpawnChance = SpawnRateConfig(true, "Red Empathy Core Solus Probe MK2 Spawn Chance", 5, config);
            GECSwarmerProbeSpawnChance = SpawnRateConfig(true, "Green Empathy Core Swarmer Probe Spawn Chance", 7, config);
            GECGaussianProbeSpawnChance = SpawnRateConfig(true, "Green Empathy Core Gaussian Probe Spawn Chance", 10, config);
            GECSolusProbeMK2SpawnChance = SpawnRateConfig(true, "Green Empathy Core Solus Probe MK2 Spawn Chance", 5, config);
            MIAeonicWispSpawnChance = SpawnRateConfig(true, "Aeonic Wisp Spawn Chance - Legendary Mask", 4, "TheMysticSword", "MysticsItems", config);
            MIKindaArchaicWispSpawnChance = SpawnRateConfig(true, "Kinda Archaic Wisp Spawn Chance - Legendary Mask", 7, "TheMysticSword", "MysticsItems", config);
            MIArchaicStoneWispSpawnChance = SpawnRateConfig(true, "Archaic Stone Wisp Spawn Chance - Legendary Mask", 2, "TheMysticSword", "MysticsItems", config);
        }
        private static ConfigEntry<float> SpawnRateConfig (bool isOther, string enemyName, float defaultValue, ConfigFile config)
        {
            if (!isOther)
            {
                return config.Bind<float>(new ConfigDefinition("4 - Custom Variants", enemyName), defaultValue, new ConfigDescription("Chance for the " + enemyName + " variant to spawn (percentage, 0-100)\nSetting this value to 0 will disable this variant from spawning.", null, Array.Empty<object>()));
            }
            else
            {
                return config.Bind<float>(new ConfigDefinition("5 - Other Variants", enemyName), defaultValue, new ConfigDescription("Chance for the " + enemyName + " variant to spawn (percentage, 0-100)\nSetting this value to 0 will disable this variant from spawning.", null, Array.Empty<object>()));
            }
        }
        private static ConfigEntry<float> SpawnRateConfig (bool isOther, string enemyName, float defaultValue, string authorName, string modName, ConfigFile config)
        {
            if (!isOther)
            {
                return config.Bind<float>(new ConfigDefinition("4 - Custom Variants", enemyName), defaultValue, new ConfigDescription("Chance for the " + enemyName + " variant to spawn (percentage, 0-100)\nOnly Spawns if " + authorName + "'s " + modName + " mod is Installed\nSetting this value to 0 will disable this variant from spawning.", null, Array.Empty<object>()));
            }
            else
            {
                return config.Bind<float>(new ConfigDefinition("5 - Other Variants", enemyName), defaultValue, new ConfigDescription("Chance for the " + enemyName + " variant to spawn (percentage, 0-100)\nOnly Spawns if " + authorName + "'s " + modName + " mod is Installed\nSetting this value to 0 will disable this variant from spawning.", null, Array.Empty<object>()));
            }
        }
    }
}
