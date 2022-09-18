using UnityEngine;

public class Bala : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.pontos++;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
