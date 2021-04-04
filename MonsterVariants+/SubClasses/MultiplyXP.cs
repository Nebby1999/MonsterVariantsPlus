/*
 *  This class handles the Extra XP recieved to the player when killing a Variant.
 *  The amount recieved is the Base xp Multiplied by a Multiplier that's Dependant on the type of Variant
 */
using RoR2;
using MonsterVariants.Components;
using MonsterVariants;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyXP
    {
        public static uint MultiplyExperience(uint monsterXP, CharacterBody victimBody) //Multiplies the XP from the monster
        {
            foreach (VariantHandler i in victimBody.GetComponents<VariantHandler>())
            {
                float xpMultCommon = ConfigLoader.CommonXPMult; //Common Variant's XP Multiplier
                float xpMultUncommon = ConfigLoader.UncommonXPMult; //Uncommon Variant's XP Multiplier
                float xpMultRare = ConfigLoader.RareXPMult; //Rare Variant's XP Multiplier
                if (i.isVariant) //Check if the monster killed is a Variant
                {
                    if (i.tier == MonsterVariantTier.Common) //If the Variant is a common Variant, multiply XP
                    {
                        float commonXP = Convert.ToInt32(monsterXP); //Converts the base XP from uint to Int32
                        commonXP *= xpMultCommon; //Multiplies the XP
                        return Convert.ToUInt32(commonXP); //Give the new amount of XP to the player
                    }
                    else if (i.tier == MonsterVariantTier.Uncommon) //If the Variant is an uncommon Variant, multiply XP
                    {
                        float uncommonXP = Convert.ToInt32(monsterXP); //Converts the base XP from uint to Int32
                        uncommonXP *= xpMultUncommon; //Multiplies the XP
                        return Convert.ToUInt32(uncommonXP); //Give the new amount of XP to the player
                    }
                    else //If the variant is not a common or an uncommon variant, then it's a Rare variant, thus, multiply XP
                    {
                        float rareXP = Convert.ToInt32(monsterXP); //Converts the base XP from uint to Int32
                        rareXP *= xpMultRare; //Multiplies the XP
                        return Convert.ToUInt32(rareXP); //Give the new amount of XP to the player
                    }
                }
            }
            return monsterXP; //Monster killed was not a variant, make no changes to the gold recieved.
        }
    }
}
