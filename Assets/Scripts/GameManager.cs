using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}
    public int vida=10;
    public int pontos=0;
    //public GameObject bala;
    
    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //bala.GetComponent<GameObject>();
    }
    public GameManager getInstance() { return instance; }
}
