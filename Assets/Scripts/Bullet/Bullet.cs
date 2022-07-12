using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 0.1f;

    

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        transform.Translate(0f, 0f, bulletSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
      
        other.GetComponent<PlayerHealth>()?.Die();

        //?. 연산자
        //(expression)?. : expression이 null이 아니면 맴버에 접근함

    }
}
