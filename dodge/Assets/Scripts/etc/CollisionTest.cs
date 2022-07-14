using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[OncollisionEnter] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[OncollisionStay] Me : {gameObject.name}, Other : {collision.gameObject.name}");

    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[OncollisionExit] Me : {gameObject.name}, Other : {collision.gameObject.name}");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("플레이어와 충돌함.");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"[OnTriggerEnter] Me : {gameObject.name}, Other : {other.name}");

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"[OnTriggerExit] Me : {gameObject.name}, Other : {other.name}");

    }
    private void Start()
    {

    }
    private void Update()
    {

    }
}
