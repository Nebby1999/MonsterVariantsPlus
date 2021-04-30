using EntityStates;
using MonsterVariantsPlus.SubClasses.Skills.States;
using RoR2;
using RoR2.Skills;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Skills
{
    internal class CustomSkills
    {
        public static SkillDef emptySkillDef;
        public static SkillDef multiSlamDef;
        public static SkillDef hoarderSitDef;
        public static SkillDef xlRecoverDef;
        public static SkillDef kamikazeBlinkDef;
        public static SkillDef wispAmalgamateDef;
        public static SkillDef chargeArchCannonDef;
        //public static SkillDef DeploySwarmDef;

        internal static void RegisterSkills()
        {
            Loadouts.AddSkill(typeof(EmptySkill));
            Loadouts.AddSkill(typeof(States.Parent.MultiSlam));
            Loadouts.AddSkill(typeof(States.Scavenger.HoarderSit));
            Loadouts.AddSkill(typeof(States.ClayDunestrider.XLRecover));
            Loadouts.AddSkill(typeof(States.VoidReaver.KamikazeBlink));
            Loadouts.AddSkill(typeof(States.GreaterWisp.WispAmalgamateCharge));
            Loadouts.AddSkill(typeof(States.LesserWisp.ChargeArchwispCannon));
            //Loadouts.AddSkill(typeof(States.RoboBallBoss.DeploySwarm));

            //Skill that does absolutely nothing, useful for getting variants without a certain skill (No teleporting imps/parents)
            emptySkillDef = NewSkillDef(new SerializableEntityStateType(typeof(EmptySkill)), "Body");
            //An Attempt at a modified parent slam attack
            multiSlamDef = NewSkillDef(new SerializableEntityStateType(typeof(States.Parent.MultiSlam)), "Body");
            //Used for the hoarder scavanger.
            hoarderSitDef = NewSkillDef(new SerializableEntityStateType(typeof(States.Scavenger.HoarderSit)), "Body");
            xlRecoverDef = NewSkillDef(new SerializableEntityStateType(typeof(States.ClayDunestrider.XLRecover)), "Body");
            kamikazeBlinkDef = NewSkillDef(new SerializableEntityStateType(typeof(States.VoidReaver.KamikazeBlink)), "Body");
            wispAmalgamateDef = NewSkillDef(new SerializableEntityStateType(typeof(States.GreaterWisp.WispAmalgamateCharge)), "Weapon");
            chargeArchCannonDef = NewSkillDef(new SerializableEntityStateType(typeof(States.LesserWisp.ChargeArchwispCannon)), "Weapon");
            //DeploySwarmDef = NewSkillDef(new SerializableEntityStateType(typeof(States.RoboBallBoss.DeploySwarm)), "Weapon");

            emptySkillDef.baseMaxStock = 0;
            emptySkillDef.requiredStock = 1000;

            hoarderSitDef.baseMaxStock = 1;
            hoarderSitDef.baseRechargeInterval = 10f;
            hoarderSitDef.requiredStock = 1;
            hoarderSitDef.stockToConsume = 1;

            xlRecoverDef.baseMaxStock = 1;
            xlRecoverDef.baseRechargeInterval = 90f;
            xlRecoverDef.requiredStock = 1;
            xlRecoverDef.stockToConsume = 1;

            wispAmalgamateDef.baseMaxStock = 1;
            wispAmalgamateDef.baseRechargeInterval = 4f;
            wispAmalgamateDef.requiredStock = 1;
            wispAmalgamateDef.stockToConsume = 1;

            chargeArchCannonDef.baseMaxStock = 1;
            chargeArchCannonDef.baseRechargeInterval = 3f;
            chargeArchCannonDef.requiredStock = 1;
            chargeArchCannonDef.stockToConsume = 1;
        }
        private static SkillDef NewSkillDef(SerializableEntityStateType state, string stateMachine)
        {
            return NewSkillDef(state, stateMachine, 1, 0, 0);
        }

        private static SkillDef NewSkillDef(SerializableEntityStateType state, string stateMachine, int stock, float cooldown, int stockConsumed)
        {
            SkillDef skillDef = ScriptableObject.CreateInstance<SkillDef>();

            skillDef.skillName = "SKILL_LUNAR_PRIMARY_REPLACEMENT_NAME";
            skillDef.skillNameToken = "SKILL_LUNAR_PRIMARY_REPLACEMENT_NAME";
            skillDef.skillDescriptionToken = "SKILL_LUNAR_PRIMARY_REPLACEMENT_DESCRIPTION";
            skillDef.icon = null;

            skillDef.activationState = state;
            skillDef.activationStateMachineName = stateMachine;
            skillDef.baseMaxStock = stock;
            skillDef.baseRechargeInterval = cooldown;
            skillDef.beginSkillCooldownOnSkillEnd = false;
            skillDef.canceledFromSprinting = false;
            skillDef.forceSprintDuringState = false;
            skillDef.fullRestockOnAssign = true;
            skillDef.interruptPriority = InterruptPriority.Any;
            skillDef.resetCooldownTimerOnUse = false;
            skillDef.isCombatSkill = true;
            skillDef.mustKeyPress = false;
            skillDef.cancelSprintingOnActivation = true;
            skillDef.rechargeStock = 1;
            skillDef.requiredStock = 1;
            skillDef.stockToConsume = stockConsumed;

            Loadouts.AddSkillDef(skillDef);

            return skillDef;
        }

    }
}
