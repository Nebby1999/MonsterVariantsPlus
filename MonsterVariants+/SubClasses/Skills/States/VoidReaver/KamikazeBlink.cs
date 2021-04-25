// EntityStates.ImpMonster.BlinkState
using EntityStates;
using EntityStates.ImpMonster;
using RoR2;
using RoR2.Navigation;
using RoR2.Projectile;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Skills.States.VoidReaver
{
    public class KamikazeBlink : BaseState
    {
        // Token: 0x06003A5F RID: 14943 RVA: 0x000F15E8 File Offset: 0x000EF7E8
        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound(BlinkState.beginSoundString, base.gameObject);
            this.modelTransform = base.GetModelTransform();
            this.GetComponent<CharacterMotor>().mass = 69420f;
            if (this.modelTransform)
            {
                this.animator = this.modelTransform.GetComponent<Animator>();
                this.characterModel = this.modelTransform.GetComponent<CharacterModel>();
                this.hurtboxGroup = this.modelTransform.GetComponent<HurtBoxGroup>();
            }
            if (this.characterModel)
            {
                this.characterModel.invisibilityCount++;
            }
            if (this.hurtboxGroup)
            {
                HurtBoxGroup hurtBoxGroup = this.hurtboxGroup;
                int hurtBoxesDeactivatorCounter = hurtBoxGroup.hurtBoxesDeactivatorCounter + 1;
                hurtBoxGroup.hurtBoxesDeactivatorCounter = hurtBoxesDeactivatorCounter;
            }
            if (base.characterMotor)
            {
                base.characterMotor.enabled = false;
            }
            Vector3 b = base.inputBank.moveVector * KamikazeBlink.blinkDistance;
            this.blinkDestination = base.transform.position;
            this.blinkStart = base.transform.position;
            NodeGraph groundNodes = SceneInfo.instance.groundNodes;
            NodeGraph.NodeIndex nodeIndex = groundNodes.FindClosestNode(base.transform.position + b, base.characterBody.hullClassification);
            groundNodes.GetNodePosition(nodeIndex, out this.blinkDestination);
            this.blinkDestination += base.transform.position - base.characterBody.footPosition;
            this.CreateBlinkEffect(Util.GetCorePosition(base.gameObject));
        }

        // Token: 0x06003A60 RID: 14944 RVA: 0x000F1764 File Offset: 0x000EF964
        private void CreateBlinkEffect(Vector3 origin)
        {
            EffectData effectData = new EffectData();
            effectData.rotation = Util.QuaternionSafeLookRotation(this.blinkDestination - this.blinkStart);
            effectData.origin = origin;
            EffectManager.SpawnEffect(BlinkState.blinkPrefab, effectData, false);
        }

        // Token: 0x06003A61 RID: 14945 RVA: 0x000E1E96 File Offset: 0x000E0096
        private void SetPosition(Vector3 newPosition)
        {
            if (base.characterMotor)
            {
                base.characterMotor.Motor.SetPositionAndRotation(newPosition, Quaternion.identity, true);
            }
        }

        // Token: 0x06003A62 RID: 14946 RVA: 0x000F17A8 File Offset: 0x000EF9A8
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            this.stopwatch += Time.fixedDeltaTime;
            if (base.characterMotor && base.characterDirection)
            {
                base.characterMotor.velocity = Vector3.zero;
            }
            this.SetPosition(Vector3.Lerp(this.blinkStart, this.blinkDestination, this.stopwatch / BlinkState.duration));
            if (this.stopwatch >= BlinkState.duration && base.isAuthority)
            {
                this.detonate();
                this.outer.SetNextStateToMain();
            }
        }

        // Token: 0x06003A63 RID: 14947 RVA: 0x000F183C File Offset: 0x000EFA3C
        public override void OnExit()
        {
            Util.PlaySound(BlinkState.endSoundString, base.gameObject);
            this.CreateBlinkEffect(Util.GetCorePosition(base.gameObject));
            this.modelTransform = base.GetModelTransform();
            if (this.modelTransform && BlinkState.destealthMaterial)
            {
                TemporaryOverlay temporaryOverlay = this.animator.gameObject.AddComponent<TemporaryOverlay>();
                temporaryOverlay.duration = 1f;
                temporaryOverlay.destroyComponentOnEnd = true;
                temporaryOverlay.originalMaterial = BlinkState.destealthMaterial;
                temporaryOverlay.inspectorCharacterModel = this.animator.gameObject.GetComponent<CharacterModel>();
                temporaryOverlay.alphaCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
                temporaryOverlay.animateShaderAlpha = true;
            }
            if (this.characterModel)
            {
                this.characterModel.invisibilityCount--;
            }
            if (this.hurtboxGroup)
            {
                HurtBoxGroup hurtBoxGroup = this.hurtboxGroup;
                int hurtBoxesDeactivatorCounter = hurtBoxGroup.hurtBoxesDeactivatorCounter - 1;
                hurtBoxGroup.hurtBoxesDeactivatorCounter = hurtBoxesDeactivatorCounter;
            }
            if (base.characterMotor)
            {
                base.characterMotor.enabled = true;
            }
            base.PlayAnimation("Gesture, Additive", "BlinkEnd");
            if (base.isAuthority)
            {
                base.characterBody.AddTimedBuff(RoR2Content.Buffs.CloakSpeed, 1f);
                base.characterBody.isSprinting = true;
            }
            base.OnExit();
        }

        protected BlastAttack.Result detonate()
        {
            return new BlastAttack
            {
                attacker = base.gameObject,
                inflictor = base.gameObject,
                teamIndex = TeamComponent.GetObjectTeam(base.gameObject),
                baseDamage = this.damageStat,
                procCoefficient = 1f,
                damageType = DamageType.Stun1s,
                crit = Util.CheckRoll(base.characterBody.crit, base.characterBody.master),
                position = base.characterBody.transform.position,
                radius = 5f,
                falloffModel = BlastAttack.FalloffModel.None,
                attackerFiltering = AttackerFiltering.NeverHit
            }.Fire();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Frozen;
        }

        // Token: 0x04003499 RID: 13465
        private Transform modelTransform;

        // Token: 0x0400349A RID: 13466
        public static GameObject blinkPrefab;

        // Token: 0x0400349B RID: 13467
        public static Material destealthMaterial;

        // Token: 0x0400349C RID: 13468
        private float stopwatch;

        // Token: 0x0400349D RID: 13469
        private Vector3 blinkDestination = Vector3.zero;

        // Token: 0x0400349E RID: 13470
        private Vector3 blinkStart = Vector3.zero;

        // Token: 0x0400349F RID: 13471
        public static float duration = 0.3f;

        // Token: 0x040034A0 RID: 13472
        public static float blinkDistance = 120f;

        // Token: 0x040034A1 RID: 13473
        public static string beginSoundString;

        // Token: 0x040034A2 RID: 13474
        public static string endSoundString;

        // Token: 0x040034A3 RID: 13475
        private Animator animator;

        // Token: 0x040034A4 RID: 13476
        private CharacterModel characterModel;

        // Token: 0x040034A5 RID: 13477
        private HurtBoxGroup hurtboxGroup;
    }
}