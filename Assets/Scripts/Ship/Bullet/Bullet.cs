using Game;
using UnityEngine;

namespace Ship.Bullet
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private void Awake()
        {
            Collider bulletCollider = GetComponent<Collider>();
            bulletCollider.isTrigger = true;

            Rigidbody bulletRigidbody = GetComponent<Rigidbody>();
            bulletRigidbody.useGravity = false;
            bulletRigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag(Constants.TagEnemy) == false) return;

            Destroy(gameObject);
            Destroy(collision.gameObject);
            Manager.Instance.IncrementTotalPoints();
        }
    }
}
