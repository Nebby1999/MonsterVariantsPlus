using RoR2;
using MonsterVariants.Components;
using MonsterVariants;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyXP
    {
        public static uint MultiplyExperience(uint monsterXP, VariantHandler enemyVariant)
        {
            // Mult = Multiplier
            float xpMultCommon = ConfigLoader.CommonXPMult;
            float xpMultUncommon = ConfigLoader.UncommonXPMult;
            float xpMultRare = ConfigLoader.RareXPMult;
            if (enemyVariant.tier == MonsterVariantTier.Common)
            {
                float commonXP = Convert.ToInt32(monsterXP);
                commonXP *= xpMultCommon;
                return Convert.ToUInt32(commonXP);
            }
            else if (enemyVariant.tier == MonsterVariantTier.Uncommon)
            {
                float uncommonXP = Convert.ToInt32(monsterXP);
                uncommonXP *= xpMultUncommon;
                return Convert.ToUInt32(uncommonXP);
            }
            else
            {
                float rareXP = Convert.ToInt32(monsterXP);
                rareXP *= xpMultRare;
                return Convert.ToUInt32(rareXP);
            }
        }
    }
}
