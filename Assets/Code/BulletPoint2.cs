using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoint2 : MonoBehaviour
{

    public GameObject Bullet2;
    // Update is called once per frame
    void Update()
    {

            if (Input.GetButtonDown("Fire2"))
            {

                Instantiate(Bullet2, transform.position, transform.rotation);

            }

        
    }
}
