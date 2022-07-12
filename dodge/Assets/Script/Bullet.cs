using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody bulletRigidbody;
    public GameManager gameManager;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 2f);
        gameManager = FindObjectOfType<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
               playerController.Die();
            }
        }
    }

    void Update()
    {
        if(gameManager.isGameOver)
        {
            this.transform.Rotate(0f, 5000 * Time.deltaTime, 0f);
            Debug.Log("개구리 돌아야해");
        }
    }
}
