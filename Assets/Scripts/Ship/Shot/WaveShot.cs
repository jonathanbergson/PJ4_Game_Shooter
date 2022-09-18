using UnityEngine;
using Ship.Bullet;

namespace Ship.Shot
{
    public class WaveShot : IShot
    {
        private static readonly Vector3[] Directions = {
            Vector3.forward,
            new(0.5f, 0, 0.5f),
            Vector3.right,
            new(0.5f, 0, -0.5f),
            Vector3.back,
            new(-0.5f, 0, -0.5f),
            Vector3.left,
            new(-0.5f, 0, 0.5f),
        };

        public void Shoot(Transform origin, BulletScriptableObject bullet)
        {
            foreach (var direction in Directions)
            {
                var bulletObject = Object.Instantiate(bullet.prefab, origin.position, Quaternion.identity);
                if (bulletObject.TryGetComponent(out Rigidbody rb))
                    rb.velocity = direction * bullet.speed;
            }
        }
    }
}
