using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelociity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelociity;
    }
    public void Die()
    {
        gameObject.SetActive(false);
        FindObjectOfType<BulletSpawner>().transform.Rotate(0f, speed * Time.deltaTime, 0f);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
