using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        Vector3 dir = Vector3.up;
        transform.position += dir *speed * Time.deltaTime;
    }
}
