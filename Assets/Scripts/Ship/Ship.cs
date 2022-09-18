using UnityEngine;
using Ship.Bullet;
using Ship.Shot;

namespace Ship
{
    public class Ship : MonoBehaviour
    {
        private const int Speed = 20;
        private IShot _shot;
        [SerializeField] private Transform cannon;
        [SerializeField] private BulletScriptableObject bullet;

        private void Awake()
        {
            _shot = new SingleShot();
        }

        private void Update()
        {
            HandleMove();
            HandleShoot();
            HandleChangeShot();
        }

        private void HandleMove()
        {
            float inputHorizontal = Input.GetAxis("Horizontal");
            float inputVertical = Input.GetAxis("Vertical") * -1;

            var position = transform.position;
            position += new Vector3(inputVertical, 0, inputHorizontal) * Speed * Time.deltaTime;
            position = new Vector3
            {
                x = Mathf.Clamp(position.x, -12f, 12f),
                y = 0f,
                z = Mathf.Clamp(position.z, -22f, 22f),
            };
            transform.position = position;
        }

        private void HandleShoot()
        {
            if (Input.GetKeyDown(KeyCode.Space)) _shot.Shoot(cannon, bullet);
        }

        private void HandleChangeShot()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) _shot = new SingleShot();
            else if (Input.GetKeyDown(KeyCode.Alpha2)) _shot = new WaveShot();
            else if (Input.GetKeyDown(KeyCode.Alpha3)) _shot = new TripleShot();
        }
    }
}
