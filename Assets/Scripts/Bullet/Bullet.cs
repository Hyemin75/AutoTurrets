using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
        
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
      
        other.GetComponent<PlayerHealth>()?.Die();

        //?. ������
        //(expression)?. : expression�� null�� �ƴϸ� �ɹ��� ������

    }

    public float bulletSpeed = 0.1f;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        transform.Translate(0f, 0f, bulletSpeed);
    }
}