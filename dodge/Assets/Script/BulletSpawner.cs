using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefeb;
    public float spawnRateMin = 0.001f;
    public float spawnRateMax = 0.001f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;

    public GameManager gameManager;
    public Transform player;

    private bool isTrigger = false;


    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;

        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            this.transform.LookAt(target);
            timeAfterSpawn += Time.deltaTime;

            if (timeAfterSpawn >= spawnRate)
            {
                timeAfterSpawn = 0f;
                GameObject bullet = Instantiate(bulletPrefeb, transform.position, transform.rotation);
                bullet.transform.LookAt(target);

                spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            }
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTrigger = false;
        }        
    }
    void Update()
    {
        if (!isTrigger)
        {
            this.transform.Rotate(0f, 500 * Time.deltaTime, 0f);
        }
    }
}



