using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helimove : MonoBehaviour
{
    public Transform bigPropeller;
    public Transform miniPropeller;
    public Rigidbody helicopter;

    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bigPropeller.Rotate(new Vector3(0, speed, 0));
        miniPropeller.Rotate(new Vector3(speed, 0, 0));
        
        helicopter.AddForce(0f, speed, 0f);

        if (Input.GetKey(KeyCode.Space))
        {
            speed += Time.deltaTime;
        }

        else
        {
            if (speed <= 0f)
            {
                speed = 0;
            }
            else 
            { 
                speed -= Time.deltaTime;
            }
        }

    }
}
