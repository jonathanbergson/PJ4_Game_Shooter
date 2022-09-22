using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        public Transform p1, p2;
        public float speed;
        float t;
        private void Update()
        {
            t = Mathf.PingPong(Time.time * speed, 1.0f);
            transform.position = Vector3.Lerp(p1.position, p2.position, t);   
        }
    }
}
