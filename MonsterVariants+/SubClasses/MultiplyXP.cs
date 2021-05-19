using RoR2;
using MonsterVariants.Components;
using MonsterVariants;
using System;

namespace MonsterVariantsPlus.SubClasses
{
    public class MultiplyXP
    {
        private static float RewardMultiplier = 1f;
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
            
            switch (enemyVariant.tier)
            {
                case MonsterVariantTier.Common:
                    float commonXP = Convert.ToInt32(monsterXP);
                    commonXP *= xpMultCommon;
                    return Convert.ToUInt32(commonXP);
                case MonsterVariantTier.Uncommon:
                    float uncommonXP = Convert.ToInt32(monsterXP);
                    uncommonXP *= xpMultUncommon;
                    return Convert.ToUInt32(uncommonXP);
                case MonsterVariantTier.Rare:
                    float rareXP = Convert.ToInt32(monsterXP);
                    rareXP *= xpMultRare;
                    return Convert.ToUInt32(rareXP);
            }
            //This return shouldnt even exist, but its needed for the code to work.
            return monsterXP;
        }
    }
}
