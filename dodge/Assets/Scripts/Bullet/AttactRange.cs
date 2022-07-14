using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttactRange : MonoBehaviour
{
    public BulletSpawner bulletSpawner;
    void OnTriggerStay(Collider other) // 범위에 들어온 상대가 플레이어라면 공격
    {
        if (other.tag == "Player")
        {
            Vector3 toPlayerVector = bulletSpawner.target.position - transform.position;
            float dot = Vector3.Dot(transform.forward, toPlayerVector.normalized);

            Vector3 cross = Vector3.Cross(transform.forward, bulletSpawner.target.position);
            Debug.Log(dot);
            if (0f < dot && dot < 0.5f && cross.y < 0f)
            {
                bulletSpawner.isTrigger = true;
            }
            else
            {
                bulletSpawner.isTrigger = false;
            }
        }
    }
    void OnTriggerExit(Collider other) // 범위에서 상대가 나갔다면 공격멈춤
    {
        if (other.tag == "Player")
        {
            bulletSpawner.isTrigger = false;
        }
    }
}
