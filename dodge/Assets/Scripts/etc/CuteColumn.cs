using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuteColumn : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    void Update()
    {
        if (gameManager.isGameOver)
        {
            transform.Rotate(0f, speed * Time.deltaTime,0f);
        }
    }
}
