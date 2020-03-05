using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{



    public GameObject deathBacteriaSound;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlueBullet") {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Instantiate(deathBacteriaSound, transform.position, Quaternion.identity);
            
        }
    }
}
