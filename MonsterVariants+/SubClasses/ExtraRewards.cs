/*
 * This Class handles the spawning of Item rewards when killing an Enemy Variant.
 * The Reward always starts at white, and then there's a chance for said white to be upgraded to Green, and then another chance to be upgraded to Red.
*/
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
            var greenItems = Run.instance.availableTier2DropList; //Grabs all the possible Green items.
            var nextGreenItems = Run.instance.treasureRng.RangeInt(0, greenItems.Count); //Picks a random Green item from the list above
            var redItems = Run.instance.availableTier3DropList; //Grabs all the possible Red items
            var nextRedItems = Run.instance.treasureRng.RangeInt(0, redItems.Count); //Picks a random Red item from the list above
            if (enemyVariant.tier == MonsterVariantTier.Common)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.CommonRedChance) //If RNG is less than the Green chance, spawn a R Item
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.CommonGreenChance + ConfigLoader.CommonRedChance) //If RNG is less than the Green chance, spawn a G Item
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.CommonWhiteChance + ConfigLoader.CommonGreenChance + ConfigLoader.CommonRedChance) //If RNG is less than the White chance, spawn a W Item
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
            if (enemyVariant.tier == MonsterVariantTier.Uncommon)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.UncommonRedChance) //If RNG is less than the Green chance, spawn a R Item
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.UncommonGreenChance + ConfigLoader.UncommonRedChance) //If RNG is less than the Green chance, spawn a G Item
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.UncommonWhiteChance + ConfigLoader.UncommonGreenChance + ConfigLoader.UncommonRedChance) //If RNG is less than the White chance, spawn a W Item
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
            if (enemyVariant.tier == MonsterVariantTier.Rare)
            {
                float rng = Random.Range(0f, 100f);
                if (rng < ConfigLoader.RareRedChance) //If RNG is less than the Green chance, spawn a R Item
                {
                    CreateDroplet(redItems, nextRedItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.RareGreenChance + ConfigLoader.RareRedChance) //If RNG is less than the Green chance, spawn a G Item
                {
                    CreateDroplet(greenItems, nextGreenItems, victimBody, playerBody);
                }
                else if (rng < ConfigLoader.RareWhiteChance + ConfigLoader.RareGreenChance + ConfigLoader.RareRedChance) //If RNG is less than the White chance, spawn a W Item
                {
                    CreateDroplet(whiteItems, nextWhiteItems, victimBody, playerBody);
                }
            }
        }
        private static void CreateDroplet(List<PickupIndex> itemList, int nextItem, CharacterBody victimBody, CharacterBody playerBody) //Creates a Pickup based off the position of the defeated variant.
        {
            if(ConfigLoader.ItemSpawnsOnPlayer)
            {
                PickupDropletController.CreatePickupDroplet(itemList[nextItem], playerBody.transform.position, (Vector3.up * 20f) + (5 * Vector3.right * Mathf.Cos(Offset)) + (5 * Vector3.forward * Mathf.Sin(Offset)));
            }
            else
            {
                PickupDropletController.CreatePickupDroplet(itemList[nextItem], victimBody.transform.position, (Vector3.up * 20f) + (5 * Vector3.right * Mathf.Cos(Offset)) + (5 * Vector3.forward * Mathf.Sin(Offset)));
            }
        }
    }
}
