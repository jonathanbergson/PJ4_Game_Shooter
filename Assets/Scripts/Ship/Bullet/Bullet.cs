using Game;
using UnityEngine;

namespace Ship.Bullet
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private const float TimeToAutoDestroy = 10.0f;

        private void Awake()
        {
            Collider bulletCollider = GetComponent<Collider>();
            bulletCollider.isTrigger = true;

            Rigidbody bulletRigidbody = GetComponent<Rigidbody>();
            bulletRigidbody.useGravity = false;
            bulletRigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;

            Invoke(nameof(AutoDestroy), TimeToAutoDestroy);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Constants.TagEnemy) == false) return;

            AutoDestroy();
            Destroy(other.gameObject);
            Manager.Instance.IncrementTotalPoints();
        }

        private void AutoDestroy()
        {
            Destroy(gameObject);
        }
    }
}
