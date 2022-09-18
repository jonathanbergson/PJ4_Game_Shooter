using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.pontos++;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
