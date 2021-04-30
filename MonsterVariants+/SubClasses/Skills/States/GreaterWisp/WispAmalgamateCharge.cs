// EntityStates.Wisp1Monster.ChargeEmbers
using EntityStates;
using EntityStates.Wisp1Monster;
using MonsterVariantsPlus.SubClasses.Skills.States;
using RoR2;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Skills.States.GreaterWisp
{
    public class WispAmalgamateCharge : BaseState
    {
        public static float baseDuration = 3f;

        public static GameObject chargeEffectLeftPrefab;
        private GameObject chargeEffectInstanceLeft;

        public static GameObject chargeEffectRightPrefab;
        private GameObject chargeEffectInstanceRight;

        public static GameObject laserEffectPrefab;
        private GameObject laserEffectInstanceLeft;
        private GameObject laserEffectInstanceRight;
        private LineRenderer laserEffectInstanceLineRenderer;

        public static string attackString;
        private float duration;
        private float stopwatch;
        private uint soundID;

        public override void OnEnter()
        {
            attackString = ChargeEmbers.attackString;
            chargeEffectLeftPrefab = ChargeEmbers.chargeEffectPrefab;
            chargeEffectRightPrefab = ChargeEmbers.chargeEffectPrefab;
            laserEffectPrefab = ChargeEmbers.laserEffectPrefab;

            base.OnEnter();
            stopwatch = 0f;
            duration = baseDuration / attackSpeedStat;
            soundID = Util.PlayAttackSpeedSound(attackString, base.gameObject, attackSpeedStat);
            PlayAnimation("Gesture", "ChargeCannons", "ChargeCannons.playbackRate", duration);
            Transform modelTransform = GetModelTransform();
            if ((bool)modelTransform)
            {
                ChildLocator component = modelTransform.GetComponent<ChildLocator>();
                if ((bool)component)
                {
                    Transform transform1 = component.FindChild("MuzzleLeft");
                    Transform transform2 = component.FindChild("MuzzleRight");
                    if ((bool)transform1)
                    {
                        if ((bool)chargeEffectLeftPrefab)
                        {
                            chargeEffectInstanceLeft = Object.Instantiate(chargeEffectLeftPrefab, transform.position, transform.rotation);
                            chargeEffectInstanceLeft.transform.parent = transform;
                            ScaleParticleSystemDuration component2 = chargeEffectInstanceLeft.GetComponent<ScaleParticleSystemDuration>();
                            if ((bool)component2)
                            {
                                component2.newDuration = duration;
                            }
                        }
                        if ((bool)laserEffectPrefab)
                        {
                            laserEffectInstanceLeft = Object.Instantiate(chargeEffectLeftPrefab, transform.position, transform.rotation);
                            laserEffectInstanceLeft.transform.parent = transform;
                            laserEffectInstanceLineRenderer = laserEffectInstanceLeft.GetComponent<LineRenderer>();
                        }
                    }
                    if ((bool)transform2)
                    {
                        if ((bool)chargeEffectRightPrefab)
                        {
                            chargeEffectInstanceRight = Object.Instantiate(chargeEffectRightPrefab, transform.position, transform.rotation);
                            chargeEffectInstanceRight.transform.parent = transform;
                            ScaleParticleSystemDuration component2 = chargeEffectInstanceRight.GetComponent<ScaleParticleSystemDuration>();
                            if ((bool)component2)
                            {
                                component2.newDuration = duration;
                            }
                        }
                        if ((bool)laserEffectPrefab)
                        {
                            laserEffectInstanceRight = Object.Instantiate(laserEffectPrefab, transform.position, transform.rotation);
                            laserEffectInstanceRight.transform.parent = transform;
                            laserEffectInstanceLineRenderer = laserEffectInstanceRight.GetComponent<LineRenderer>();
                        }
                    }
                }
            }
            if ((bool)base.characterBody)
            {
                base.characterBody.SetAimTimer(duration);
            }
        }

        public override void OnExit()
        {
            PlayAnimation("Gesture", "Empty");
            base.OnExit();
            if ((bool)chargeEffectRightPrefab)
            {
                EntityState.Destroy(chargeEffectInstanceRight);
            }
            if ((bool)laserEffectInstanceRight)
            {
                EntityState.Destroy(laserEffectInstanceRight);
            }
            if ((bool)chargeEffectLeftPrefab)
            {
                EntityState.Destroy(chargeEffectInstanceLeft);
            }
            if ((bool)laserEffectInstanceLeft)
            {
                EntityState.Destroy(laserEffectInstanceLeft);
            }
        }

        public override void Update()
        {
            base.Update();
            Ray aimRay = GetAimRay();
            float distance = 100f;
            Vector3 origin = aimRay.origin;
            Vector3 point = aimRay.GetPoint(distance);
            laserEffectInstanceLineRenderer.SetPosition(0, origin);
            laserEffectInstanceLineRenderer.SetPosition(1, point);
            Color startColor = new Color(1f, 1f, 1f, stopwatch / duration);
            Color clear = Color.clear;
            laserEffectInstanceLineRenderer.startColor = startColor;
            laserEffectInstanceLineRenderer.endColor = clear;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            stopwatch += Time.fixedDeltaTime;
            if (stopwatch >= duration && base.isAuthority)
            {
                outer.SetNextState(new WispAmalgamateFire());
            }
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}