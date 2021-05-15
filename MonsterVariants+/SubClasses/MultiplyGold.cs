using MonsterVariants;
using MonsterVariants.Components;
using RoR2;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyGold
    {
        private static int RewardMultiplier = 1;
        public static uint MultiplyMoney(uint monsterGold, VariantHandler enemyVariant)
        {
            if (RunArtifactManager.instance.IsArtifactEnabled(Artifact.Variance))
            {
                if (ConfigLoader.ArtifactIncreasesRewards)
                {
                    RewardMultiplier = ConfigLoader.SpawnRateMultiplier;
                }
            }
            //Mult = Multiplier
            float moneyMultCommon = ConfigLoader.CommonMoneyMult * RewardMultiplier;
            float moneyMultUncommon = ConfigLoader.UncommonMoneyMult * RewardMultiplier;
            float moneyMultRare = ConfigLoader.RareMoneyMult * RewardMultiplier;

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
