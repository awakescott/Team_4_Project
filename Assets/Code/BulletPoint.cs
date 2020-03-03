using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoint : MonoBehaviour
{

    public GameObject Bullet1;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            Instantiate(Bullet1, transform.position, transform.rotation);

        }
        
    }

}
