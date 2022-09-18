using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform cano;
    public float velocidade = 5f;    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
    }
    void Disparar()
    {

        GameObject cb = Instantiate(bala, cano.position, bala.transform.rotation);
        Rigidbody rb = cb.GetComponent<Rigidbody>();
        rb.AddForce(cano.forward * velocidade, ForceMode.Impulse);

    }
}  
