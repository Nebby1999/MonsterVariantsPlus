// EntityStates.ImpMonster.BlinkState
using EntityStates;
using RoR2;
using RoR2.Navigation;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Skills.States
{
    public class KamikazeBlink : BaseState
    {
        private Transform modelTransform;

        public static GameObject blinkPrefab;

        public static Material destealthMaterial;

        private float stopwatch;

        private Vector3 blinkDestination = Vector3.zero;

        private Vector3 blinkStart = Vector3.zero;

        public static float duration = 0.3f;

        public static float blinkDistance = 25f;

        public static string beginSoundString;

        public static string endSoundString;

        private Animator animator;

        private CharacterModel characterModel;

        private HurtBoxGroup hurtboxGroup;

        public override void OnEnter()
        {
            base.OnEnter();
            Util.PlaySound(beginSoundString, base.gameObject);
            modelTransform = GetModelTransform();
            if ((bool)modelTransform)
            {
                animator = modelTransform.GetComponent<Animator>();
                characterModel = modelTransform.GetComponent<CharacterModel>();
                hurtboxGroup = modelTransform.GetComponent<HurtBoxGroup>();
            }
            if ((bool)characterModel)
            {
                characterModel.invisibilityCount++;
            }
            if ((bool)hurtboxGroup)
            {
                hurtboxGroup.hurtBoxesDeactivatorCounter++;
            }
            if ((bool)base.characterMotor)
            {
                base.characterMotor.enabled = false;
            }
            Vector3 vector = base.inputBank.moveVector * blinkDistance;
            blinkDestination = base.transform.position;
            blinkStart = base.transform.position;
            NodeGraph groundNodes = SceneInfo.instance.groundNodes;
            NodeGraph.NodeIndex nodeIndex = groundNodes.FindClosestNode(base.transform.position + vector, base.characterBody.hullClassification);
            groundNodes.GetNodePosition(nodeIndex, out blinkDestination);
            blinkDestination += base.transform.position - base.characterBody.footPosition;
            CreateBlinkEffect(Util.GetCorePosition(base.gameObject));
        }

        private void CreateBlinkEffect(Vector3 origin)
        {
            EffectData effectData = new EffectData();
            effectData.rotation = Util.QuaternionSafeLookRotation(blinkDestination - blinkStart);
            effectData.origin = origin;
            EffectManager.SpawnEffect(blinkPrefab, effectData, transmit: false);
        }

        private void SetPosition(Vector3 newPosition)
        {
            if ((bool)base.characterMotor)
            {
                base.characterMotor.Motor.SetPositionAndRotation(newPosition, Quaternion.identity);
            }
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            stopwatch += Time.fixedDeltaTime;
            if ((bool)base.characterMotor && (bool)base.characterDirection)
            {
                base.characterMotor.velocity = Vector3.zero;
            }
            SetPosition(Vector3.Lerp(blinkStart, blinkDestination, stopwatch / duration));
            if (stopwatch >= duration && base.isAuthority)
            {
                outer.SetNextStateToMain();
            }
        }

        public override void OnExit()
        {
            Util.PlaySound(endSoundString, base.gameObject);
            CreateBlinkEffect(Util.GetCorePosition(base.gameObject));
            modelTransform = GetModelTransform();
            if ((bool)modelTransform && (bool)destealthMaterial)
            {
                TemporaryOverlay temporaryOverlay = animator.gameObject.AddComponent<TemporaryOverlay>();
                temporaryOverlay.duration = 1f;
                temporaryOverlay.destroyComponentOnEnd = true;
                temporaryOverlay.originalMaterial = destealthMaterial;
                temporaryOverlay.inspectorCharacterModel = animator.gameObject.GetComponent<CharacterModel>();
                temporaryOverlay.alphaCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
                temporaryOverlay.animateShaderAlpha = true;
            }
            if ((bool)characterModel)
            {
                characterModel.invisibilityCount--;
            }
            if ((bool)hurtboxGroup)
            {
                hurtboxGroup.hurtBoxesDeactivatorCounter--;
            }
            if ((bool)base.characterMotor)
            {
                base.characterMotor.enabled = true;
            }
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}