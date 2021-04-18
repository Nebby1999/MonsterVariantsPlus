/*
 * Main plugin class, tells Bepinex that this is a Mod.
 * Class initializes the Config files, and it's main purpose is checking if the killed monster was a Variant.
*/
using BepInEx;
using RoR2;
using MonsterVariantsPlus.SubClasses;
using MonsterVariants;
using UnityEngine;
using System.Collections.Generic;

namespace MonsterVariantsPlus
{
    [BepInDependency("com.bepis.r2api")]
    [BepInDependency("com.rob.MonsterVariants")]
    [BepInPlugin("com.Nebby1999.MonsterVariantsPlus", "Monster Variants +", "1.2.1")]
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
        public void Start() //As soon as the game begins, register variants
        {
            RegisterCustomVariants();
        }
        internal static void RegisterCustomVariants() //Registers the new custom variants
        {
            //Mosquito Wisp - Low Health, Damage & Size, fast movement and attack speed. meant as an annoyance
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "Wisp",
                spawnRate = ConfigLoader.MosquitoWispSpawnChance,
                variantTier = MonsterVariantTier.Common,
                sizeModifier = FlyingSizeModifier(0.5f),
                healthMultiplier = 0.5f,
                moveSpeedMultiplier = 2.0f,
                attackSpeedMultiplier = 2.0f,
                damageMultiplier = 1f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Steel Contraption - Higher Size, health and damage, lower movement speed and attack speed. 
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "Bell",
                spawnRate = ConfigLoader.SteelContraptionSpawnChance,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = FlyingSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.5f,
                attackSpeedMultiplier = 0.5f,
                damageMultiplier = 1.5f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = null,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Mortar Crab - Larger Version of a hermit crab slightly faster in attacking, has a brilliant behemoth.
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "HermitCrab",
                spawnRate = ConfigLoader.MortarCrabSpawnChance,
                variantTier = MonsterVariantTier.Uncommon,
                sizeModifier = GroundSizeModifier(1.5f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 0.8f,
                attackSpeedMultiplier = 0.8f,
                damageMultiplier = 1.25f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = SimpleInventory("Behemoth", 1),
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
            //Vampiric Templar - Clay Templar with tritip daggers and leeching seeds.
            AddVariant(new MonsterVariantInfo
            {
                bodyName = "ClayBruiserMonster",
                spawnRate = ConfigLoader.VampiricTemplarSpawnChance,
                variantTier = MonsterVariantTier.Rare,
                sizeModifier = GroundSizeModifier(1.25f),
                healthMultiplier = 1.5f,
                moveSpeedMultiplier = 1.0f,
                attackSpeedMultiplier = 1.25f,
                damageMultiplier = 0.9f,
                armorMultiplier = 1f,
                armorBonus = 0f,
                customInventory = vampiricInventory,
                meshReplacement = null,
                materialReplacement = null,
                skillReplacement = null
            });
        }
        internal static void AddVariant(MonsterVariantInfo info) //Adds the new variant using monsterVariant's Variant Handler.
        {
            MonsterVariants.Components.VariantHandler variantHandler = Resources.Load<GameObject>("Prefabs/CharacterBodies/" + info.bodyName + "Body").AddComponent<MonsterVariants.Components.VariantHandler>();
            variantHandler.Init(info);
        }

        readonly static ItemInfo[] vampiricInventory = new ItemInfo[]
        {
            SimpleItem("Dagger", 2),
            SimpleItem("Seed", 10)
        };
        internal static ItemInfo[] SimpleInventory(string itemName, int itemCount) //Creates an inventory for a Variant that has just 1 type of item.
        {
            ItemInfo info = SimpleItem(itemName, itemCount);

            List<ItemInfo> infos = new List<ItemInfo>();

            infos.Add(info);

            ItemInfo[] newInfos = infos.ToArray();

            return newInfos;
        }
        internal static ItemInfo SimpleItem(string itemName, int itemCount)
        {
            ItemInfo info = ScriptableObject.CreateInstance<ItemInfo>();
            info.itemString = itemName;
            info.count = itemCount;

            return info;
        }
        internal static MonsterSizeModifier GroundSizeModifier(float newSize)
        {
            MonsterSizeModifier sizeModifier = ScriptableObject.CreateInstance<MonsterSizeModifier>();
            sizeModifier.newSize = newSize;
            sizeModifier.scaleCollider = false;

            return sizeModifier;
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
