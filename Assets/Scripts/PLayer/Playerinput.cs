using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinput : MonoBehaviour
{
    //프로퍼티로 bool 타입의 up, Down, Left, Right 만들기
    //기본적으로 input은 다른 곳에서 사용해야함

    public float X { get; private set; }
    public float Y { get; private set; }

 

    // Update is called once per frame
    void Update()
    {
        //이전 값을 날리고, 기본 값으로 초기화
        X = Y = 0f;
        // 현재 프레임의 입력 값을 저장
        X = Input.GetAxis("Horizontal"); //-1~ 1
        Y = Input.GetAxis("Vertical"); //-1~ 1

        //Up = Input.GetKey(KeyCode.UpArrow) || /Input.GetKey/(KeyCode.W);
        //Down = Input.GetKey(KeyCode.DownArrow) || //Input.GetKey(KeyCode.S); ;
        //Left = Input.GetKey(KeyCode.LeftArrow) || //Input.GetKey(KeyCode.A); ;
        //Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D); ;



   
    }
}
