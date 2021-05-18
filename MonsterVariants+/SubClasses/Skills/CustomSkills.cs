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
        public static SkillDef wispAmalgamateDef;
        public static SkillDef chargeArchCannonDef;
        public static SkillDef beetleSwarmDef;
        public static SkillDef onlyBeetleSwarmDef;
        public static SkillDef chargeSingleFireballDef;
        public static SkillDef megaBrassBallDef;
        public static SkillDef golemLaserDef;
        public static SkillDef chargeWispLaserDef;
        public static SkillDef chargeDoubleWispLaserDef;
        public static SkillDef chargeMegaWispLaserDef;
        //public static SkillDef DeploySwarmDef;

        internal static void RegisterSkills()
        {
            Loadouts.AddSkill(typeof(EmptySkill));
            Loadouts.AddSkill(typeof(States.Parent.MultiSlam));
            Loadouts.AddSkill(typeof(States.Scavenger.HoarderSit));
            Loadouts.AddSkill(typeof(States.ClayDunestrider.XLRecover));
            Loadouts.AddSkill(typeof(States.GreaterWisp.WispAmalgamateCharge));
            Loadouts.AddSkill(typeof(States.LesserWisp.ChargeArchwispCannon));
            Loadouts.AddSkill(typeof(States.BeetleQueen.BeetleSwarm));
            Loadouts.AddSkill(typeof(States.BeetleQueen.OnlyBeetleSwarm));
            Loadouts.AddSkill(typeof(States.ElderLemurian.ChargeSingleFireball));
            Loadouts.AddSkill(typeof(States.BrassContraption.MegaBrassBall));
            Loadouts.AddSkill(typeof(States.StoneGolem.ChargeLaser));
            Loadouts.AddSkill(typeof(States.LesserWisp.ChargeWispLaser));
            Loadouts.AddSkill(typeof(States.GreaterWisp.ChargeDoubleWispLaser));
            Loadouts.AddSkill(typeof(States.ArchaicWisp.ChargeMegaWispLaser));

            //Loadouts.AddSkill(typeof(States.RoboBallBoss.DeploySwarm));

            //Skill that does absolutely nothing, useful for getting variants without a certain skill (No teleporting imps/parents)
            emptySkillDef = NewSkillDef(new SerializableEntityStateType(typeof(EmptySkill)), "Body");
            //An Attempt at a modified parent slam attack
            multiSlamDef = NewSkillDef(new SerializableEntityStateType(typeof(States.Parent.MultiSlam)), "Body");
            //Used for the hoarder scavanger.
            hoarderSitDef = NewSkillDef(new SerializableEntityStateType(typeof(States.Scavenger.HoarderSit)), "Body");
            xlRecoverDef = NewSkillDef(new SerializableEntityStateType(typeof(States.ClayDunestrider.XLRecover)), "Body");
            wispAmalgamateDef = NewSkillDef(new SerializableEntityStateType(typeof(States.GreaterWisp.WispAmalgamateCharge)), "Weapon");
            chargeArchCannonDef = NewSkillDef(new SerializableEntityStateType(typeof(States.LesserWisp.ChargeArchwispCannon)), "Weapon");
            beetleSwarmDef = NewSkillDef(new SerializableEntityStateType(typeof(States.BeetleQueen.BeetleSwarm)), "Body");
            onlyBeetleSwarmDef = NewSkillDef(new SerializableEntityStateType(typeof(States.BeetleQueen.OnlyBeetleSwarm)), "Body");
            chargeSingleFireballDef = NewSkillDef(new SerializableEntityStateType(typeof(States.ElderLemurian.ChargeSingleFireball)), "Weapon");
            megaBrassBallDef = NewSkillDef(new SerializableEntityStateType(typeof(States.BrassContraption.MegaBrassBall)), "Weapon");
            golemLaserDef = NewSkillDef(new SerializableEntityStateType(typeof(States.StoneGolem.ChargeLaser)), "Weapon");
            chargeWispLaserDef = NewSkillDef(new SerializableEntityStateType(typeof(States.LesserWisp.ChargeWispLaser)), "Weapon");
            chargeDoubleWispLaserDef = NewSkillDef(new SerializableEntityStateType(typeof(States.GreaterWisp.ChargeDoubleWispLaser)), "Weapon");
            chargeMegaWispLaserDef = NewSkillDef(new SerializableEntityStateType(typeof(States.ArchaicWisp.ChargeMegaWispLaser)), "Weapon");

            BuildSkillDefs(emptySkillDef, 0, 1000);
            BuildSkillDefs(hoarderSitDef, 1, 1, 10f, 1);
            BuildSkillDefs(xlRecoverDef, 1, 1, 10f, 1);
            BuildSkillDefs(wispAmalgamateDef, 1, 1, 4f, 1);
            BuildSkillDefs(chargeArchCannonDef, 1, 1, 3f, 1);
            BuildSkillDefs(beetleSwarmDef, 1, 1, 30f, 1);
            BuildSkillDefs(onlyBeetleSwarmDef, 1, 1, 15, 1);
            BuildSkillDefs(chargeSingleFireballDef, 5, 1, 3, 1, 5);
            BuildSkillDefs(megaBrassBallDef, 1, 1, 5, 1);
            BuildSkillDefs(golemLaserDef, 1, 1, 10, 1);
            BuildSkillDefs(chargeWispLaserDef, 1, 1, 6, 1);
            BuildSkillDefs(chargeDoubleWispLaserDef, 1, 1, 9, 1);
            BuildSkillDefs(chargeMegaWispLaserDef, 1, 1, 10, 1);
        }

        private static void BuildSkillDefs(SkillDef skillDef, int baseMaxStock, int requiredStock)
        {
            skillDef.baseMaxStock = baseMaxStock;
            skillDef.requiredStock = requiredStock;
        }
        private static void BuildSkillDefs(SkillDef skillDef, int baseMaxStock, int requiredStock, float cooldownInSeconds, int stockToConsume)
        {
            skillDef.baseMaxStock = baseMaxStock;
            skillDef.requiredStock = requiredStock;
            skillDef.baseRechargeInterval = cooldownInSeconds;
            skillDef.stockToConsume = stockToConsume;
        }
        private static void BuildSkillDefs(SkillDef skillDef, int baseMaxStock, int requiredStock, float cooldownInSeconds, int stockToConsume, int rechargeStock)
        {
            skillDef.baseMaxStock = baseMaxStock;
            skillDef.requiredStock = requiredStock;
            skillDef.baseRechargeInterval = cooldownInSeconds;
            skillDef.stockToConsume = stockToConsume;
            skillDef.rechargeStock = rechargeStock;
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
