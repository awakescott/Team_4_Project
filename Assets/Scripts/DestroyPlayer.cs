using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject gameManager;
<<<<<<< HEAD
    public GameObject deathPlayerSound;
=======
    public GameObject Timer;
>>>>>>> origin/UI-Timer

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            gameManager.SendMessage("OnPlayerDied");
<<<<<<< HEAD
            Instantiate(deathPlayerSound, transform.position, Quaternion.identity);
=======
            Timer.SendMessage("StopTimer");
>>>>>>> origin/UI-Timer
        }
    }
}
