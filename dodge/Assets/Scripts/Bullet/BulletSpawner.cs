using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletSpawner : MonoBehaviour
{
    public Transform target; // �߻��� ���

    public float spawnRateMin; // �ּ� �����ֱ�
    public float spawnRateMax; // �ִ� �����ֱ�

    public GameManager gameManager;

    [Header("�Ѿ� ������")] // �ν����� â�� �̻ڰ� �ٹ� �� �־��
    [SerializeField] // Private�ε� �ν����� â���� �� �� �־��
    private GameObject bulletPrefeb; // ������ �Ѿ� 
    private float spawnRate; // �����ֱ�
    private float timeAfterSpawn = 0f; // �ֱ� ���� �������� �����ð�

    public bool isTrigger = false; // �Ѿ��� ��� �������� Ȯ��

    Bullet bullet;
    void Start()
    {
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
    }    
    void Update()
    {
        if (isTrigger)
        {
            attact();
        }
        else // �Ѿ��� ������� ���� �� ȥ�� Y������ ���ư�
        {
            //transform.Rotate(0f, 500 * Time.deltaTime, 0f);
        }
    }
    void attact()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate) // ���� ������ ������ �� ����
        {
            timeAfterSpawn = 0f;
            // ������ ����
            GameObject bullet =
                Instantiate(bulletPrefeb, transform.position, transform.rotation);
            bullet.transform.LookAt(target); // �Ѿ��� Ÿ���� ��� �ٶ�

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}