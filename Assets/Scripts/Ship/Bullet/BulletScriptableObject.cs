using UnityEngine;

namespace Ship.Bullet
{
    [CreateAssetMenu]
    public class BulletScriptableObject : ScriptableObject
    {
        public GameObject prefab;
        public float speed;
    }
}
