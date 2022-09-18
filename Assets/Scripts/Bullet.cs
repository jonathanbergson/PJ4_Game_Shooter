using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public GameObject bala;/* GameManager.instance.bala.GetComponent<GameObject>();*/

     void Start()
    {
        bala = GetComponent<GameObject>();
    }
    void Update()
    {
        Atirar();
    }
    void Atirar()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
    }
}   
