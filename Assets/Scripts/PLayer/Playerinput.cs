using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinput : MonoBehaviour
{
    //������Ƽ�� bool Ÿ���� up, Down, Left, Right �����
    //�⺻������ input�� �ٸ� ������ ����ؾ���

    public float X { get; private set; }
    public float Y { get; private set; }

 

    // Update is called once per frame
    void Update()
    {
        //���� ���� ������, �⺻ ������ �ʱ�ȭ
        X = Y = 0f;
        // ���� �������� �Է� ���� ����
        X = Input.GetAxis("Horizontal"); //-1~ 1
        Y = Input.GetAxis("Vertical"); //-1~ 1

        //Up = Input.GetKey(KeyCode.UpArrow) || /Input.GetKey/(KeyCode.W);
        //Down = Input.GetKey(KeyCode.DownArrow) || //Input.GetKey(KeyCode.S); ;
        //Left = Input.GetKey(KeyCode.LeftArrow) || //Input.GetKey(KeyCode.A); ;
        //Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D); ;



   
    }
}
