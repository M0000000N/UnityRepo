using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttactRange : MonoBehaviour
{
    public BulletSpawner bulletSpawner;
    void OnTriggerStay(Collider other) // ������ ���� ��밡 �÷��̾��� ����
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
    void OnTriggerExit(Collider other) // �������� ��밡 �����ٸ� ���ݸ���
    {
        if (other.tag == "Player")
        {
            bulletSpawner.isTrigger = false;
        }
    }
}
