using MonsterVariants;
using MonsterVariants.Components;
using RoR2;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyGold
    {
        public static uint MultiplyMoney(uint monsterGold, VariantHandler enemyVariant)
        {
            //Mult = Multiplier
            float moneyMultCommon = ConfigLoader.CommonMoneyMult;
            float moneyMultUncommon = ConfigLoader.UncommonMoneyMult;
            float moneyMultRare = ConfigLoader.RareMoneyMult;

            if (enemyVariant.tier == MonsterVariantTier.Common)
            {
                float commonGold = Convert.ToInt32(monsterGold);
                commonGold *= moneyMultCommon;
                return Convert.ToUInt32(commonGold);
            }
            else if (enemyVariant.tier == MonsterVariantTier.Uncommon)
            {
                float uncommonGold = Convert.ToInt32(monsterGold);
                uncommonGold *= moneyMultUncommon;
                return Convert.ToUInt32(uncommonGold);
            }
            else
            {
                float rareGold = Convert.ToInt32(monsterGold);
                rareGold *= moneyMultRare;
                return Convert.ToUInt32(rareGold);
            }
        }
    }
}
