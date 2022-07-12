using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Z { get; private set; }
    void Update()
    {
        // 이전값을 날리고 기본값으로 초기화
        X = Z = 0f;
        // 현재 프레임의 입력값을 저장
        X = Input.GetAxis("Horizontal"); // -1~1
        Z = Input.GetAxis("Vertical");    // -1~1
        
        //Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow);
        //Down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow);
        //Left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow);
        //Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow);


        Debug.Log("PlayerInput Update");
    }
}
