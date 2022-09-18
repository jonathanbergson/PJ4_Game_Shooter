using Ship.Bullet;
using UnityEngine;

namespace Ship.Shot
{
    public interface IShot
    {
        public void Shoot(Transform origin, BulletScriptableObject bullet);
    }
}
