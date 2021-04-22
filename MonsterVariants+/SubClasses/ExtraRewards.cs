using MonsterVariants.Components;
using RoR2;
using UnityEngine;
using System.Collections.Generic;
using MonsterVariants;

namespace MonsterVariantsPlus.SubClasses
{
    public class ExtraRewards
    {
        static readonly float Offset = 2f * Mathf.PI / Run.instance.participatingPlayerCount;
        public static void TryExtraReward(VariantHandler enemyVariant,CharacterBody victimBody, CharacterBody playerBody)
        {
            var whiteItems = Run.instance.availableTier1DropList; //Grabs all the possible white items.
            var nextWhiteItems = Run.instance.treasureRng.RangeInt(0, whiteItems.Count); //Picks a random white item from the list above
            var greenItems = Run.instance.availableTier2DropList;
            var nextGreenItems = Run.instance.treasureRng.RangeInt(0, greenItems.Count);
            var redItems = Run.instance.availableTier3DropList;
            var nextRedItems = Run.instance.treasureRng.RangeInt(0, redItems.Count);
            if (enemyVariant.tier == MonsterVariantTier.Common)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.CommonRedChance)
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.CommonGreenChance + ConfigLoader.CommonRedChance)
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.CommonWhiteChance + ConfigLoader.CommonGreenChance + ConfigLoader.CommonRedChance)
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
            if (enemyVariant.tier == MonsterVariantTier.Uncommon)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.UncommonRedChance)
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.UncommonGreenChance + ConfigLoader.UncommonRedChance)
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.UncommonWhiteChance + ConfigLoader.UncommonGreenChance + ConfigLoader.UncommonRedChance)
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
            if (enemyVariant.tier == MonsterVariantTier.Rare)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.RareRedChance)
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.RareGreenChance + ConfigLoader.RareRedChance)
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.RareWhiteChance + ConfigLoader.RareGreenChance + ConfigLoader.RareRedChance)
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
        }
        private static void CreateDroplet(List<PickupIndex> itemList, int nextItem, CharacterBody victimBody, CharacterBody playerBody)
        {
            if(ConfigLoader.ItemSpawnsOnPlayer)
            {
                PickupDropletController.CreatePickupDroplet(itemList[nextItem], playerBody.transform.position, (Vector3.up * 20f) + (5 * Vector3.right * Mathf.Cos(Offset)) + (5 * Vector3.forward * Mathf.Sin(Offset)));
            }
            else //Item spawns from variant.
            {
                PickupDropletController.CreatePickupDroplet(itemList[nextItem], victimBody.transform.position, (Vector3.up * 20f) + (5 * Vector3.right * Mathf.Cos(Offset)) + (5 * Vector3.forward * Mathf.Sin(Offset)));
            }
        }
    }
}
