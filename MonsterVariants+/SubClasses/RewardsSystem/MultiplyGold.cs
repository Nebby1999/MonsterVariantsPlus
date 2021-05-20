using MonsterVariants;
using MonsterVariants.Components;
using RoR2;
using System;

namespace MonsterVariantsPlus.SubClasses.RewardsSystem
{
    public class MultiplyGold
    {
        private static float RewardMultiplier = 1f;
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

            switch (enemyVariant.tier)
            {
                case MonsterVariantTier.Common:
                    float commonGold = Convert.ToInt32(monsterGold);
                    commonGold *= moneyMultCommon;
                    return Convert.ToUInt32(commonGold);
                case MonsterVariantTier.Uncommon:
                    float uncommonGold = Convert.ToInt32(monsterGold);
                    uncommonGold *= moneyMultUncommon;
                    return Convert.ToUInt32(uncommonGold);
                case MonsterVariantTier.Rare:
                    float rareGold = Convert.ToInt32(monsterGold);
                    rareGold *= moneyMultRare;
                    return Convert.ToUInt32(rareGold);
            }
            //This return shouldnt even exist, but its needed for the code to work.
            return monsterGold;
        }
    }
}
