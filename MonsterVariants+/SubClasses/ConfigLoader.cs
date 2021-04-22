using BepInEx.Configuration;

namespace MonsterVariantsPlus.SubClasses
{
    public class ConfigLoader
    {
        //Main Categories
        private static ConfigEntry<bool> EnableItemRewardsConfig { get; set; } //This creates the configuration entry.
        public static bool EnableItemRewards => EnableItemRewardsConfig.Value; //This works as a Get, must keep in mind that "EnableItemRewards" is what one should get if you want to obtain a certain config's Value!
        private static ConfigEntry<bool> EnableGoldRewardsConfig { get; set; }
        public static bool EnableGoldRewards => EnableGoldRewardsConfig.Value;
        private static ConfigEntry<bool> EnableXPRewardsConfig { get; set; }
        public static bool EnableXPRewards => EnableXPRewardsConfig.Value;
        private static ConfigEntry<bool> EnableCustomVariantsConfig { get; set; }
        public static bool EnableCustomVariants => EnableCustomVariantsConfig.Value;

        //Item Related Configs
        private static ConfigEntry<bool> ItemSpawnsOnPlayerConfig { get; set; }
        public static bool ItemSpawnsOnPlayer => ItemSpawnsOnPlayerConfig.Value;
        private static ConfigEntry<int> CommonWhiteChanceConfig { get; set; }
        public static int CommonWhiteChance => CommonWhiteChanceConfig.Value;
        private static ConfigEntry<int> CommonGreenChanceConfig { get; set; }
        public static int CommonGreenChance => CommonGreenChanceConfig.Value;
        private static ConfigEntry<int> CommonRedChanceConfig { get; set; }
        public static int CommonRedChance => CommonRedChanceConfig.Value;
        private static ConfigEntry<int> UncommonWhiteChanceConfig { get; set; }
        public static int UncommonWhiteChance => UncommonWhiteChanceConfig.Value;
        private static ConfigEntry<int> UncommonGreenChanceConfig { get; set; }
        public static int UncommonGreenChance => UncommonGreenChanceConfig.Value;
        private static ConfigEntry<int> UncommonRedChanceConfig { get; set; }
        public static int UncommonRedChance => UncommonRedChanceConfig.Value;
        private static ConfigEntry<int> RareWhiteChanceConfig { get; set; }
        public static int RareWhiteChance => RareWhiteChanceConfig.Value;
        private static ConfigEntry<int> RareGreenChanceConfig { get; set; }
        public static int RareGreenChance => RareGreenChanceConfig.Value;
        private static ConfigEntry<int> RareRedChanceConfig { get; set; }
        public static int RareRedChance => RareRedChanceConfig.Value;

        //Money Related Configs
        private static ConfigEntry<float> CommonMoneyMultConfig { get; set; }
        public static float CommonMoneyMult => CommonMoneyMultConfig.Value;
        private static ConfigEntry<float> UncommonMoneyMultConfig { get; set; }
        public static float UncommonMoneyMult => UncommonMoneyMultConfig.Value;
        private static ConfigEntry<float> RareMoneyMultConfig { get; set; }
        public static float RareMoneyMult => RareMoneyMultConfig.Value;

        //XP Related Configs
        private static ConfigEntry<float> CommonXPMultConfig { get; set; }
        public static float CommonXPMult => CommonXPMultConfig.Value;
        private static ConfigEntry<float> UncommonXPMultConfig { get; set; }
        public static float UncommonXPMult => UncommonXPMultConfig.Value;
        private static ConfigEntry<float> RareXPMultConfig { get; set; }
        public static float RareXPMult => RareXPMultConfig.Value;

        //Custom Variants
        private static ConfigEntry<float> MosquitoWispSpawnChanceConfig { get; set; }
        public static float MosquitoWispSpawnChance => MosquitoWispSpawnChanceConfig.Value;
        private static ConfigEntry<float> SteelContraptionSpawnCanceConfig { get; set; }
        public static float SteelContraptionSpawnChance => SteelContraptionSpawnCanceConfig.Value;
        private static ConfigEntry<float> MortarCrabSpawnChanceConfig { get; set; }
        public static float MortarCrabSpawnChance => MortarCrabSpawnChanceConfig.Value;
        private static ConfigEntry<float> VampiricTemplarSpawnChanceConfig { get; set; }
        public static float VampiricTemplarSpawnChance => VampiricTemplarSpawnChanceConfig.Value;
        private static ConfigEntry<float> ADShroomSpawnChanceConfig { get; set; }
        public static float ADShroomSpawnChance => ADShroomSpawnChanceConfig.Value;
        private static ConfigEntry<float> HealerShroomSpawnChanceConfig { get; set; }
        public static float HealerShroomSpawnChance => HealerShroomSpawnChanceConfig.Value;
        private static ConfigEntry<float> AdolescentSpawnChanceConfig { get; set; }
        public static float AdolescentSpawnChance => AdolescentSpawnChanceConfig.Value;
        private static ConfigEntry<float> ChildSpawnChanceConfig { get; set; }
        public static float ChildSpawnChance => ChildSpawnChanceConfig.Value;
        private static ConfigEntry<float> BruiserImpSpawnChanceConfig { get; set; }
        public static float BruiserImpSpawnChance => BruiserImpSpawnChanceConfig.Value;
        private static ConfigEntry<float> AlphaBisonSpawnChanceConfig { get; set; }
        public static float AlphaBisonSpawnChance => AlphaBisonSpawnChanceConfig.Value;
        //private static ConfigEntry<float> KamikazeReaverSpawnChanceConfig { get; set; }
        //public static float KamikazeReaverSpawnChance => KamikazeReaverSpawnChanceConfig.Value;
        private static ConfigEntry<float> SunPriestSpawnChanceConfig { get; set; }
        public static float SunPriestSpawnChance => SunPriestSpawnChanceConfig.Value;
        private static ConfigEntry<float> HoarderSpawnChanceConfig { get; set; }
        public static float HoarderSpawnChance => HoarderSpawnChanceConfig.Value;
        private static ConfigEntry<float> StarvingDunestriderSpawnChanceConfig { get; set; }
        public static float StarvingDunestriderSpawnChance => StarvingDunestriderSpawnChanceConfig.Value;
        private static ConfigEntry<float> DevourerDunestriderspawnChanceConfig { get; set; }
        public static float DevourerDunestriderSpawnChance => DevourerDunestriderspawnChanceConfig.Value;
        private static ConfigEntry<float> ClaySoldierSpawnChanceConfig { get; set; }
        public static float ClaySoldierSpawnChance => ClaySoldierSpawnChanceConfig.Value;

        public static void SetupConfigLoader(ConfigFile config) //Creates the description and some mumbojumbo for the values.
        {
            EnableItemRewardsConfig = config.Bind<bool>("Item Rewards", "Enable Item Rewards", true, "If this is set to True, then Enemy Variants have a chance to drop Items. If this is set to False,\nthen the rest of the available options in this category are disabled.");
            EnableGoldRewardsConfig = config.Bind<bool>("Gold Rewards", "Enable Gold Rewards", true, "If this is set to True, then Enemy Variants will drop extra gold based off a multiplier.\nIf this is set to False, then the rest of the available options of this category are disabled.");
            EnableXPRewardsConfig = config.Bind<bool>("XP Rewards", "Enable XP Rewards", true, "If this is set to True, then Enemy Variants will drop extra XP based off a multiplier.\nIf this is set to False, then the rest of the available options of this category are disabled.");
            EnableCustomVariantsConfig = config.Bind<bool>("Custom Variants", "Enable Custom Variants", true, "If this is set to True, then new Enemy Variants designed by nebby will begin spawning, all the effects of killing a regular variant also apply to these.\nIf this is set to False, then the rest of the available options in this category are disabled.");

            ItemSpawnsOnPlayerConfig = config.Bind<bool>("Item Rewards", "Item Rewards Spawns on Player", false, "Normally the item reward's droplet spawns from the center of the slain Variant.\nThis can cause some issues with killing Variants that are on top of the death plane, or get knocked back onto it, Since the item will be lost in the process.\nSetting this to True causes all Item Rewards to be spawned at the center of the Player who killed the variant.");

            CommonWhiteChanceConfig = config.Bind<int>("Item Rewards", "Common Variant White Item Drop Chance", 3, "The chance that a Common variant drops a White item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            CommonGreenChanceConfig = config.Bind<int>("Item Rewards", "Common Variant Green Item Drop Chance", 0, "The chance that a Common variant drops a Green item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            CommonRedChanceConfig = config.Bind<int>("Item Rewards", "Common Variant Red Item Drop Chance", 0, "The chance that a Common variant drops a Red item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            UncommonWhiteChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant White Item Drop Chance", 5, "The chance that an Uncommon variant drops a White Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            UncommonGreenChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant Green Item Drop Chance", 1, "The chance that an Uncommon variant drops a Green Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            UncommonRedChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant Red Item Drop Chance", 0, "The chance that an Uncommon variant drops a Red Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            RareWhiteChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant White Item Drop Chance", 10, "The chance that a Rare variant drops a White Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            RareGreenChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant Green Item Drop Chance", 5, "The chance that a Rare variant drops a Green Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");
            RareRedChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant Red Item Drop Chance", 1, "The chance that a Rare variant drops a Red Item. Accepted values range from 0 to 100.\n(Set this value to 0 to Disable).");

            CommonMoneyMultConfig = config.Bind<float>("Gold Rewards", "Common Variant Gold Multiplier", 1.3f, "Multiplier that's applied to the Gold reward for killing a common Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");
            UncommonMoneyMultConfig = config.Bind<float>("Gold Rewards", "Uncommon Variant Gold Multiplier", 1.6f, "Multiplier that's applied to the Gold reward for killing an uncommon Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");
            RareMoneyMultConfig = config.Bind<float>("Gold Rewards", "Rare Variant Gold Multiplier", 2.0f, "Multiplier that's applied to the Gold reward for killing a rare Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");

            CommonXPMultConfig = config.Bind<float>("XP Rewards", "Common Variant XP Multiplier", 1.3f, "Multiplier that's applied to the XP reward for killing a common Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the XP recieved).");
            UncommonXPMultConfig = config.Bind<float>("XP Rewards", "Uncommon Variant XP Multiplier", 1.6f, "Multiplier that's applied to the XP reward for killing an uncommon Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the XP recieved).");
            RareXPMultConfig = config.Bind<float>("XP Rewards", "Rare Variant XP Multiplier", 2.0f, "Multiplier that's applied to the XP reward for killing a rare Variant.\n(Set this value to 1.0 to disable, values lower than this number decreases the XP recieved.");

            MosquitoWispSpawnChanceConfig = config.Bind<float>("Custom Variants", "Mosquito Wisp Spawn Chance", 7f, "Chance for a Mosquito Wisp variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            SteelContraptionSpawnCanceConfig = config.Bind<float>("Custom Variants", "Steel Contraption Spawn Chance", 7f, "Chance for a Steel Contraption variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            MortarCrabSpawnChanceConfig = config.Bind<float>("Custom Variants", "Mortar Crab Spawn Chance", 5f, "Chance for a Mortar Crab variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            VampiricTemplarSpawnChanceConfig = config.Bind<float>("Custom Variants", "Vampiric Templar Spawn Chance", 5, "Chance for a Vampiric Templar variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            ADShroomSpawnChanceConfig = config.Bind<float>("Custom Variants", "ADShroom Spawn Chance", 6, "Chance for an ADShroom (Area of Denial Shroom) variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant form spawning.");
            HealerShroomSpawnChanceConfig = config.Bind<float>("Custom Variants", "Healer Shroom Spawn Chance", 10, "Chance for a Healer Shroom Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this Variant from spawning");
            AdolescentSpawnChanceConfig = config.Bind<float>("Custom Variants", "Adolescent Spawn Chance", 8, "Chance for an Adolescent Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            ChildSpawnChanceConfig = config.Bind<float>("Custom Variants", "Child Spawn Chance", 6, "Chance for a Child Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            BruiserImpSpawnChanceConfig = config.Bind<float>("Custom Variants", "Bruiser Imp Spawn Chance", 10, "Chance for a Bruiser Imp Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            AlphaBisonSpawnChanceConfig = config.Bind<float>("Custom Variants", "Alpha Bison Spawn Chance", 5, "Chance for an Alpha Bison Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            //KamikazeReaverSpawnChanceConfig = config.Bind<float>("Custom Variants", "Kamikaze Reaver Spawn chance", 3, "Chance for a Kamikaze Reaver Variant to Spawn (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            SunPriestSpawnChanceConfig = config.Bind<float>("Custom Variants", "Sun Priest Spawn Chance", 3, "Chance for a Sun Priest Variant to Spawn, (percentage, 0-100).\nSetting this value to 0 will disable this variant from spawning.");
            HoarderSpawnChanceConfig = config.Bind<float>("Custom Variants", "Hoarder Scavenger Spawn Chance", 8, "Chance for a Hoarder Scavenger Variant to Spawn (percentage, 0-100)\nSetting this value to 0 will disable this variant from spawning.");
            StarvingDunestriderSpawnChanceConfig = config.Bind<float>("Custom Variants", "Starving Dunestrider Spawn Chance", 4, "Chance for a Starving Dunestrider to Spawn (percentage, 0-100)\nSetting this value to 0 will disable this variant from spawning.");
            DevourerDunestriderspawnChanceConfig = config.Bind<float>("Custom Variants", "Devourer Dunestrider Spawn Chance", 2, "Chance for a Devourer Dunestrider to Spawn (percentage, 0-100)\nSetting this value to 0 will disable this variant form spawning.");
            ClaySoldierSpawnChanceConfig = config.Bind<float>("Custom Variants", "Clay Soldier Spawn Chance", 15, "Chance for a Clay Soldier Variant to Spawn (percentage, 0-100)\nOnly Spawns if Moffein's ClayMen mod is Installed.\nSetting this value to 0 will disable this variant from spawning.");
        
        }
    }
}
