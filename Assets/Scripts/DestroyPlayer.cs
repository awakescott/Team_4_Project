using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject deathPlayerSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            gameManager.SendMessage("OnPlayerDied");
            Instantiate(deathPlayerSound, transform.position, Quaternion.identity);
        }
    }
}
