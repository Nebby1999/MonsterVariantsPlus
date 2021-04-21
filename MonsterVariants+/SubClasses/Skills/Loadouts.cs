using RoR2.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterVariantsPlus.SubClasses.Skills
{
    public class Loadouts
    {
        internal static List<Type> entityStates = new List<Type>();
        internal static List<SkillDef> skillDefs = new List<SkillDef>();

        internal static void AddSkill (Type type)
        {

        }
        internal static void AddSkillDef(SkillDef skillDef)
        {
            skillDefs.Add(skillDef);
        }
    }
}
