using RoR2.Skills;
using System;
using System.Collections.Generic;

namespace MonsterVariantsPlus.SubClasses.Skills
{
    internal class Loadouts
    {
        internal static List<Type> entityStates = new List<Type>();
        internal static List<SkillDef> skillDefs = new List<SkillDef>();
        internal static void AddSkill(Type type)
        {
            entityStates.Add(type);
        }
        internal static void AddSkillDef(SkillDef t)
        {
            skillDefs.Add(t);
        }
    }
}
