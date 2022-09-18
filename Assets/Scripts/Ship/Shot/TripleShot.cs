using UnityEngine;
using Ship.Bullet;

namespace Ship.Shot
{
    public class TripleShot : IShot
    {
        private const float BulletDistance = 1;

        private static readonly Vector3 BulletTopVelocity = new() { x = -0.2f, y = 0f, z = 1f };
        private static readonly Vector3 BulletCentralVelocity = Vector3.forward;
        private static readonly Vector3 BulletBottomVelocity = new() { x = 0.2f, y = 0f, z = 1f };

        public void Shoot(Transform origin, BulletScriptableObject bullet)
        {
            var originPosition = origin.position;

            Vector3 bulletTopPosition = originPosition;
            bulletTopPosition.x = originPosition.x - BulletDistance;
            GameObject bulletTop = Object.Instantiate(bullet.prefab, bulletTopPosition, Quaternion.identity);
            if (bulletTop.TryGetComponent(out Rigidbody rbTop))
                rbTop.velocity = BulletTopVelocity * bullet.speed;

            GameObject bulletCentral = Object.Instantiate(bullet.prefab, originPosition, Quaternion.identity);
            if (bulletCentral.TryGetComponent(out Rigidbody rbCentral))
                rbCentral.velocity = BulletCentralVelocity * bullet.speed;

            Vector3 bulletBottomPosition = originPosition;
            bulletBottomPosition.x = originPosition.x + BulletDistance;
            GameObject bulletBottom = Object.Instantiate(bullet.prefab, bulletBottomPosition, Quaternion.identity);
            if (bulletBottom.TryGetComponent(out Rigidbody rbBottom))
                rbBottom.velocity = BulletBottomVelocity * bullet.speed;
        }
    }
}
