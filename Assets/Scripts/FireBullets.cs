using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    public GameObject Bullet1;
    public GameObject Bullet2;
    public float fireRate1;
    public float fireRate2;
    public float nextFire;
    public Transform blueGun;
    public Transform orangeGun;

    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate1;
            Instantiate(Bullet1, blueGun.position, transform.rotation);

        }

        if (Input.GetButtonDown("Fire2") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate2;
            Instantiate(Bullet2, orangeGun.position, transform.rotation);

        }

    }
}
