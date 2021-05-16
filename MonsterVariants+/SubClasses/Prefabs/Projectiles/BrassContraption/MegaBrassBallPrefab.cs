using MonsterVariantsPlus.SubClasses.Projectiles;
using RoR2.Projectile;

using UnityEngine;

namespace MonsterVariantsPlus.SubClasses.Prefabs.Projectiles.BrassContraption
{
    public class MegaBrassBallPrefab : PrefabBase<MegaBrassBallPrefab>
    {
        public static GameObject prefab;
        public override void Init()
        {
            BuildPrefab();
            prefab = PrefabObject;
            CreateProjectilePrefab(PrefabObject);
        }
        internal void BuildPrefab()
        {
            PrefabObject = InstantiatePrefabClone("Prefabs/Projectiles/BellBall", "MegaBrassBall");
            PrefabObject.transform.localScale *= 4;
            ProjectileController ghostPrefab = PrefabObject.GetComponent<ProjectileController>();
            ghostPrefab.ghostPrefab = InstantiatePrefabClone("prefabs/projectileghosts/BellBallGhost", "MegaBrassBallGhost");
            ghostPrefab.ghostPrefab.transform.localScale *= 4;
        }
    }
}
