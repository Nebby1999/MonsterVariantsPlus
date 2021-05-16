/*Code based off this class. https://github.com/KomradeSpectre/AetheriumMod/blob/rewrite-master/Aetherium/Artifacts/ArtifactBase.cs
Simply copied and pasted certain tidbits and made modifications where needed.
Tons of credits goes to KomradeSpectre
*/
using R2API;
using UnityEngine;
using UnityEngine.Networking;

namespace MonsterVariantsPlus.SubClasses.Projectiles
{
    public abstract class PrefabBase<T> : PrefabBase where T : PrefabBase<T>
    {
        public static T instance { get; private set; }
    }

    public abstract class PrefabBase
    {
        public GameObject PrefabObject;

        public abstract void Init();
        protected GameObject InstantiatePrefabClone(string prefabPath, string prefabName)
        {
            var clone = PrefabAPI.InstantiateClone(Resources.Load<GameObject>(prefabPath), prefabName, true);
            clone.AddComponent<NetworkIdentity>();
            return clone;
        }
        protected void CreateProjectilePrefab(GameObject projectilePrefab)
        {
            if (projectilePrefab) PrefabAPI.RegisterNetworkPrefab(projectilePrefab);
            ProjectileAPI.Add(projectilePrefab);
        }
    }
}
