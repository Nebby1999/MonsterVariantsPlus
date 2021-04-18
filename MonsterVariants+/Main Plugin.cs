/*
 * Main plugin class, tells Bepinex that this is a Mod.
 * Class initializes the Config files, and it's main purpose is checking if the killed monster was a Variant.
*/
using BepInEx;
using RoR2;
using MonsterVariantsPlus.SubClasses;
using MonsterVariants;
using UnityEngine;

namespace MonsterVariantsPlus
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.1.0")]
    public class MainPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            ConfigLoader.SetupConfigLoader(Config); //Initializes the Config

            On.RoR2.DeathRewards.OnKilledServer += (orig, self, DamageReport) =>
            {
                if (DamageReport.victimTeamIndex == (TeamIndex)2) //If the Victim was part of the Enemy Team (TeamIndex)2, then proceed forward
                {
                    if (ConfigLoader.EnableItemRewards)
                    {
                        ExtraRewards.TryExtraReward(DamageReport.victimBody, DamageReport.attackerBody); //Tries to spawn an item
                    }
                    if (ConfigLoader.EnableGoldRewards)
                    {
                        uint multipliedGold = MultiplyGold.MultiplyMoney(self.goldReward, DamageReport.victimBody); //Multiplies the money given to the player
                        self.goldReward = multipliedGold; //Sets the Gold given to the player the value taken from "multipliedGold"
                    }
                    if (ConfigLoader.EnableXPRewards)
                    {
                        uint multipliedXP = MultiplyXP.MultiplyExperience(self.expReward, DamageReport.victimBody); //Multiplies the XP given to the player
                        self.expReward = multipliedXP; //Sets the Gold given to the player the value taken from "multipliedXP"
                    }
                }
                orig(self, DamageReport);
            };
        }
        public void Start()
        {
            RegisterVariants();
        }
        internal static void RegisterVariants()
        {
            //Mosquito Wisp
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                spawnRate = 100f,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 2f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
        }
        internal static void AddVariant(MonsterVariantInfo info)
        {
            MonsterVariants.Components.VariantHandler variantHandler = Resources.Load<GameObject>("Prefabs/CharacterBodies/" + info.bodyName + "Body").AddComponent<MonsterVariants.Components.VariantHandler>();
            variantHandler.Init(info);
        }
        internal static MonsterSizeModifier FlyingSizeModifier(float newSize)
        {
            MonsterSizeModifier sizeModifier = ScriptableObject.CreateInstance<MonsterSizeModifier>();
            sizeModifier.newSize = newSize;
            sizeModifier.scaleCollider = true;

            return sizeModifier;
        }
    }
}
