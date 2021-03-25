﻿/*
 * Main plugin class, tells Bepinex that this is a Mod.
 * Class initializes the Config files, and it's main purpose is checking if the killed monster was a Variant.
*/
using BepInEx;
using RoR2;
using MonsterVariantsPlus.SubClasses;

namespace Nebby1999
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
    [BepInPlugin("com.Nebby1999.MonsterVariants+", "Monster Variants +", "1.0.5")]
    public class MainPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            ConfigLoader.SetupConfigLoader(Config); //Initializes the Config

            On.RoR2.DeathRewards.OnKilledServer += (orig, self, DamageReport) =>
            {
                if (DamageReport.victimTeamIndex == (TeamIndex)2) //If the Victim was part of the Enemy Team (TeamIndex)2, then proceed forward
                {
                    if(ConfigLoader.EnableItemRewards)
                    {
                        ExtraRewards.TryExtraReward(DamageReport.victimBody); //Tries to spawn an item
                    }
                    if(ConfigLoader.EnableGoldRewards)
                    {
                        uint multipliedGold = MultiplyGold.MultiplyMoney(self.goldReward, DamageReport.victimBody); //Multiplies the money given to the player
                        self.goldReward = multipliedGold; //Sets the Gold given to the player the value taken from "multipliedGold"
                    }
                }
                orig(self, DamageReport);
            };
        }
    }
}