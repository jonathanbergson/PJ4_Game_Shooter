using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{      
    public void Update()
    {
        Hit();  
    }
    void Hit()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.vida-=1;
        }
    }
}
