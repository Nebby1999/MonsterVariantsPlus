﻿/*
 * The Configuration class handles everything regarding the Config files for the mod.
*/
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

        //Item Related Configs
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

        //Other Categories
        //private static ConfigEntry<bool> EnableDebuggerConfig { get; set; }
        //public static bool EnableDebugger => EnableDebuggerConfig.Value;

        public static void SetupConfigLoader(ConfigFile config) //Creates the description and some mumbojumbo for the values.
        {
            EnableItemRewardsConfig = config.Bind<bool>("Item Rewards", "Enable Item Rewards", true, "If this is set to True, then Enemy Variants have a chance to drop Items. If this is set to False, then the rest of the available options in this category are disabled.");
            EnableGoldRewardsConfig = config.Bind<bool>("Gold Rewards", "Enable Gold Rewards", true, "If this is set to True, then Enemy Variants will drop extra gold based off a multiplier. If this is set to False, then the rest of the available options of this category are disabled.");
            EnableXPRewardsConfig = config.Bind<bool>("XP Rewards", "Enable XP Rewards", true, "If this is set to True, then Enemy Variants will drop extra XP based off a multiplier. If this is set to False, then the rest of the available options of this category are disabled.");


            CommonWhiteChanceConfig = config.Bind<int>("Item Rewards", "Common Variant White Item Drop Chance", 3, "The chance that a Common variant drops a White item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            CommonGreenChanceConfig = config.Bind<int>("Item Rewards", "Common Variant Green Item Drop Chance", 0, "The chance that a Common variant drops a Green item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            CommonRedChanceConfig = config.Bind<int>("Item Rewards", "Common Variant Red Item Drop Chance", 0, "The chance that a Common variant drops a Red item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");

            UncommonWhiteChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant White Item Drop Chance", 5, "The chance that an Uncommon variant drops a White Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            UncommonGreenChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant Green Item Drop Chance", 1, "The chance that an Uncommon variant drops a Green Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            UncommonRedChanceConfig = config.Bind<int>("Item Rewards", "Uncommon Variant Red Item Drop Chance", 0, "The chance that an Uncommon variant drops a Red Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");

            RareWhiteChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant White Item Drop Chance", 10, "The chance that a Rare variant drops a White Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            RareGreenChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant Green Item Drop Chance", 5, "The chance that a Rare variant drops a Green Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");
            RareRedChanceConfig = config.Bind<int>("Item Rewards", "Rare Variant Red Item Drop Chance", 1, "The chance that a Rare variant drops a Red Item. Accepted values range from 0 to 100. (Set this value to 0 to Disable).");

            CommonMoneyMultConfig = config.Bind<float>("Gold Rewards", "Common Variant Gold Multiplier", 1.3f, "Multiplier that's applied to the Gold reward for killing a common Variant. (Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");
            UncommonMoneyMultConfig = config.Bind<float>("Gold Rewards", "Uncommon Variant Gold Multiplier", 1.6f, "Multiplier that's applied to the Gold reward for killing an uncommon Variant. (Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");
            RareMoneyMultConfig = config.Bind<float>("Gold Rewards", "Rare Variant Gold Multiplier", 2.0f, "Multiplier that's applied to the Gold reward for killing a rare Variant. (Set this value to 1.0 to disable, values lower than this number decreases the Gold recieved).");

            CommonXPMultConfig = config.Bind<float>("XP Rewards", "Common Variant XP Multiplier", 1.3f, "Multiplier that's applied to the XP reward for killing a common Variant. (Set this value to 1.0 to disable, values lower than this number decreases the XP recieved).");
            UncommonXPMultConfig = config.Bind<float>("XP Rewards", "Uncommon Variant XP Multiplier", 1.6f, "Multiplier that's applied to the XP reward for killing an uncommon Variant. (Set this value to 1.0 to disable, values lower than this number decreases the XP recieved).");
            RareXPMultConfig = config.Bind<float>("XP Rewards", "Rare Variant XP Multiplier", 2.0f, "Multiplier that's applied to the XP reward for killing a rare Variant. (Set this value to 1.0 to disable, values lower than this number decreases the XP recieved.");
            //EnableDebuggerConfig = config.Bind<bool>("Other Configs", "Enable The Debugger", false, "Setting this to True enables an In-Game Debugger of the mod. Logging certain information onto the Game's chat.");
        }
    }
}
