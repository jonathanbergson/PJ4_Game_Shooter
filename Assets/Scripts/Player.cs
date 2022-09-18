using UnityEngine;
using Shot;

public class Player : MonoBehaviour
{
    private const int Speed = 20;
    private IShot _shot;

    private void Awake()
    {
        _shot = new SingleShot();
    }

    private void Update()
    {
        HandleMove();
        HandleShoot();
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
        if (Input.GetKeyDown(KeyCode.Space)) _shot.Shoot();
    }
}
