using UnityEngine;
using Ship.Bullet;

namespace Ship.Shot
{
    public class WaveShot : IShot
    {
        public void Shoot(Transform origin, BulletScriptableObject bullet)
        {
            Debug.Log("Wave Shoot");
        }
    }
}
