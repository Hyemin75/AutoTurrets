using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterMovement: MonoBehaviour
{
    public float speed = 6f;
    public bool UseSpeed = false;

    private Playerinput _input;
    public Rigidbody rigidbody;
     
    // Start is called before the first frame update
    void Start()
    {
        // _input�� ���� �Ҵ�
        _input = GetComponent<Playerinput>();
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log("Player Movement Start");
    }

    // Update is called once per frame
    void Update()
    {
        // �� ���⿡ ���� ���� ���ϱ�
        float xSpeed = _input.X * speed;
        float zSpeed = _input.Y * speed;

        if(UseSpeed)
        {
            rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed); // ��� �������� �ӵ��� �� ���̳�
        }


        rigidbody.AddForce(xSpeed, 0f, zSpeed);
        
        
        //if(input.Up)
        //{
        //    rigidbody.AddForce(0, 0, speed);
        //}
        //else if(input.Down)
        //{
        //    rigidbody.AddForce(0, 0, -speed);
        //}
        //else if (input.Left)
        //{
        //    rigidbody.AddForce(-speed, 0, 0);
        //}
        //else if (input.Right)
        //{
        //    rigidbody.AddForce(speed, 0, 0);
        //}



    }
}
