﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruction2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Destroy(gameObject);
        }




    }
}
