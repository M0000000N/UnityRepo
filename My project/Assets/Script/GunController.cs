using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    //public GameObject bulletPrefeb;
    public GameObject bulletFactory;
    public GameObject bulletPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = bulletPosition.transform.position;
        }
    }
}
