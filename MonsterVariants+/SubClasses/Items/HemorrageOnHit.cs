//Class based off KomradeSpectre's Item Boiler Plate repository, TVYM <3
using R2API;
using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Items
{
    public class HemorrageOnHit : MVPItemBase
    {
        public override string ItemName => "MVP_HEMORRAGE_ON_HIT";
        public override string ItemLangTokenName => "MVP_HEMORRAGE_ON_HIT";
        public override string ItemPickupDesc => "MVP_HEMORRAGE_ON_HIT_DESC";
        public override string ItemFullDescription => "MVP_HEMORRAGE_ON_HIT_FULL_DESC";
        public override string ItemLore => "MVP_HEMORRAGE_ON_HIT_LORE";
        public override ItemTier Tier => ItemTier.NoTier;
        public override GameObject ItemModel => null;
        public override Sprite ItemIcon => null;
        public override ItemTag[] ItemTags => new ItemTag[1] { ItemTag.Damage };
        public override void Init()
        {
            CreateItem();
            CreateLang();
            Hooks();
        }
        public override ItemDisplayRuleDict CreateItemDisplayRules()
        {
            return new ItemDisplayRuleDict();
        }

        public override void Hooks()
        {
            On.RoR2.GlobalEventManager.OnHitEnemy += InflictHemorrage;
        }

        private void InflictHemorrage(On.RoR2.GlobalEventManager.orig_OnHitEnemy orig, GlobalEventManager self, DamageInfo damageInfo, GameObject victimGameObject)
        {
            if ((bool)self && (bool)damageInfo.attacker)
            {
                CharacterBody victim = victimGameObject.GetComponent<CharacterBody>();
                CharacterBody attacker = damageInfo.attacker.GetComponent<CharacterBody>();
                int count = GetCount(attacker);
                if (count > 0)
                {
                    victim.AddTimedBuff(RoR2Content.Buffs.SuperBleed, 15);
                }
            }
            orig(self, damageInfo, victimGameObject);
        }
    }
}
