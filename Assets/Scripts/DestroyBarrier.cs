﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrier : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "OrangeBullet")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }

      


    }





}
