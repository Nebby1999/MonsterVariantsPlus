using RoR2;
using MonsterVariants.Components;
using MonsterVariants;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyXP
    {
        private static int RewardMultiplier = 1;
        public static uint MultiplyExperience(uint monsterXP, VariantHandler enemyVariant)
        {
            if (RunArtifactManager.instance.IsArtifactEnabled(Artifact.Variance))
            {
                if(ConfigLoader.ArtifactIncreasesRewards)
                {
                    RewardMultiplier = ConfigLoader.SpawnRateMultiplier;
                }
            }
            // Mult = Multiplier
            float xpMultCommon = ConfigLoader.CommonXPMult * RewardMultiplier;
            float xpMultUncommon = ConfigLoader.UncommonXPMult * RewardMultiplier;
            float xpMultRare = ConfigLoader.RareXPMult * RewardMultiplier;
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
