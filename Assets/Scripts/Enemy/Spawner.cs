using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject InimigoPrefab;
	public float spawnerTime;
	public float startTime;
	float time;
    public Transform spawner;
    void Update()
    {
        startTime -= Time.deltaTime;
		 if(startTime <= 0){
		 	Instanciar();
		 }        
    }

    void Instanciar(){
        time -= Time.deltaTime;
		if(time <= 0){
        time = spawnerTime;
        GameObject inimigo =Instantiate(InimigoPrefab, spawner.transform.position, spawner.transform.rotation);
         }
    }

}
