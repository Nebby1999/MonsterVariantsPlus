// EntityStates.ScavMonster.EnterSit
using EntityStates.ScavMonster;
using RoR2;

namespace MonsterVariantsPlus.SubClasses.Skills.States.Scavenger
{
    public class HoarderSit : BaseSitState
    {
        private float duration;

        public override void OnEnter()
        {
            base.OnEnter();
            this.duration = EnterSit.baseDuration / this.attackSpeedStat;

            Util.PlaySound(EnterSit.soundString, base.gameObject);
            PlayCrossfade("Body", "EnterSit", "Sit.playbackRate", duration, 0.1f);

            base.modelLocator.normalizeToFloor = true;
            base.modelLocator.modelTransform.GetComponent<AimAnimator>().enabled = true;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.fixedAge >= duration)
            {
                outer.SetNextState(new FindItem());
            }
        }
    }
}