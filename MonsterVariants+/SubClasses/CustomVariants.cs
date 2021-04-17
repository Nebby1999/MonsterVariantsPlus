
using MonsterVariantsPlus;
using MonsterVariants.Components;
using RoR2;
using UnityEngine;
using MonsterVariants;

namespace MonsterVariantsPlus.SubClasses
{
    public class CustomVariants
    {
        internal static void RegisterCustomVariants()
        {
            MainPlugin.AddVariant(new MonsterVariants.MonsterVariantInfo //Steel Contraption
            {
                bodyName = "Bell",
                spawnRate = 100,
                variantTier = MonsterVariants.MonsterVariantTier.Rare,
                sizeModifier = FlyingSizeModifier(2f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.7f,
                attackSpeedMultiplier = 0.5f,
                damageMultiplier = 2f,
                armorMultiplier = 1f,
                armorBonus = 0,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
        }
        internal static MonsterSizeModifier FlyingSizeModifier(float newSize)
        {
            MonsterSizeModifier sizeModifer = ScriptableObject.CreateInstance<MonsterSizeModifier>();
            sizeModifer.newSize = newSize;
            sizeModifer.scaleCollider = true;

            return sizeModifer;
        }
    }
}
