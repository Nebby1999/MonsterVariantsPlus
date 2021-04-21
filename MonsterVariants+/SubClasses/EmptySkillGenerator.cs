using EntityStates;
using RoR2;
using RoR2.Skills;
using UnityEngine;

namespace MonsterVariantsPlus.SubClasses
{
    internal class EmptySkillGenerator
    {
        public static SkillDef emptySkillDef;
        internal static void RegisterSkills()
        {
            emptySkillDef = Resources.Load<GameObject>("Prefabs/CharacterBodies/CommandoBody").GetComponent<SkillLocator>().primary.skillFamily.variants[0].skillDef;
            emptySkillDef.baseMaxStock = 0;
        }
    }
}
