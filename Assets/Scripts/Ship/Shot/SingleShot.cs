using UnityEngine;
using Ship.Bullet;

namespace Ship.Shot
{
    public class SingleShot : IShot
    {
        public void Shoot(Transform origin, BulletScriptableObject bullet)
        {
            GameObject bulletObject = Object.Instantiate(bullet.prefab, origin.position, Quaternion.identity);
            if (bulletObject.TryGetComponent(out Rigidbody rb))
                rb.velocity = Vector3.forward * bullet.speed;
        }
    }
}
