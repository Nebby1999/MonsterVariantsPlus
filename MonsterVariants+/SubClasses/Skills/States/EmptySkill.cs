﻿using System;
using RoR2;
using EntityStates;

namespace MonsterVariantsPlus.SubClasses.Skills.States
{
    public class EmptySkill : BaseState
    {
        public override void OnEnter()
        {
            base.OnEnter();
            
        }
        public override void OnExit()
        {
            base.OnExit();
        }
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            this.outer.SetNextStateToMain();
        }
        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return base.GetMinimumInterruptPriority();
        }
    }
}
