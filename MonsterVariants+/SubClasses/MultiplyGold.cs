/*
 * This class handles the Extra Gold recieved to the player when killing a Variant.
 * The amount recieved is the Base gold Multiplied by a Multiplier that's Dependant on the type of Variant.
 */
using MonsterVariants;
using MonsterVariants.Components;
using RoR2;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyGold
    {
        public static uint MultiplyMoney(uint monsterGold, CharacterBody victimBody) //Multiplies the Gold from the Monster
        {
            foreach (VariantHandler i in victimBody.GetComponents<VariantHandler>())
            {
                float moneyMultCommon = ConfigLoader.CommonMoneyMult; //Common Variant's Gold Multiplier
                float moneyMultUncommon = ConfigLoader.UncommonMoneyMult; //Uncommon Variant's Gold Multiplier
                float moneyMultRare = ConfigLoader.RareMoneyMult; //Rare Variant's Gold Multiplier
                if (i.isVariant) //Check if the monster killed is a Variant
                {
                    if (i.tier == MonsterVariantTier.Common) //If the Variant is a common variant, multiply Gold
                    {
                        float commonGold = Convert.ToInt32(monsterGold); //Converts the base gold from uint to int32
                        commonGold *= moneyMultCommon; //Multiplies the Gold
                        return Convert.ToUInt32(commonGold); //Give the new amount of gold to the player
                    }
                    else if (i.tier == MonsterVariantTier.Uncommon) //If the Variant is an uncommon variant, multiply Gold
                    {
                        float uncommonGold = Convert.ToInt32(monsterGold); //Converts the base gold from uint to int32
                        uncommonGold *= moneyMultUncommon; //Multiplies the Gold
                        return Convert.ToUInt32(uncommonGold); //Give the new amount of gold to the player
                    }
                    else //If the variant is not a common or an uncommon variant, then its a Rare variant, thus, multiply Gold.
                    {
                        float rareGold = Convert.ToInt32(monsterGold); //Converts the base gold from uint to int32
                        rareGold *= moneyMultRare; //Multiplies the Gold
                        return Convert.ToUInt32(rareGold); //Give the new amount of gold to the player
                    }
                }
            }
            return monsterGold; //Monster killed was not a variant, make no changes to the gold recieved
        }
    }
}
