﻿using EntityStates;
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
        internal static void RegisterSkills()
        {
            Loadouts.AddSkill(typeof(EmptySkill));
            Loadouts.AddSkill(typeof(MultiSlam));

            //Skill that does absolutely nothing, useful for getting variants without a certain skill (No teleporting imps/parents)
            emptySkillDef = NewSkillDef(new SerializableEntityStateType(typeof(EmptySkill)), "Body");
            //An Attempt at a modified parent slam attack
            multiSlamDef = NewSkillDef(new SerializableEntityStateType(typeof(MultiSlam)), "Body");

            emptySkillDef.baseMaxStock = 0;
            emptySkillDef.requiredStock = 1000;
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