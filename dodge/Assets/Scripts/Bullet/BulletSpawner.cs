using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletSpawner : MonoBehaviour
{
    public Transform target; // 발사할 대상

    public float spawnRateMin; // 최소 생성주기
    public float spawnRateMax; // 최대 생성주기

    public GameManager gameManager;

    [Header("총알 프리펩")] // 인스펙터 창을 이쁘게 꾸밀 수 있어요
    [SerializeField] // Private인데 인스펙터 창에서 쓸 수 있어요
    private GameObject bulletPrefeb; // 생성할 총알 
    private float spawnRate; // 생성주기
    private float timeAfterSpawn = 0f; // 최근 생성 시점에서 지난시간

    public bool isTrigger = false; // 총알을 쏘는 범위인지 확인

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
        else // 총알을 쏘고있지 않을 때 혼자 Y축으로 돌아감
        {
            //transform.Rotate(0f, 500 * Time.deltaTime, 0f);
        }
    }
    void attact()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawnRate) // 일정 시점이 지났을 때 마다
        {
            timeAfterSpawn = 0f;
            // 종알을 생성
            GameObject bullet =
                Instantiate(bulletPrefeb, transform.position, transform.rotation);
            bullet.transform.LookAt(target); // 총알은 타겟을 계속 바라봄

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}