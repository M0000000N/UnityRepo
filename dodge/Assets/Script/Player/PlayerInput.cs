using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Z { get; private set; }
    void Update()
    {
        // �������� ������ �⺻������ �ʱ�ȭ
        X = Z = 0f;
        // ���� �������� �Է°��� ����
        X = Input.GetAxis("Horizontal"); // -1~1
        Z = Input.GetAxis("Vertical");    // -1~1
        
        //Up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow);
        //Down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow);
        //Left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow);
        //Right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow);


        Debug.Log("PlayerInput Update");
    }
}
