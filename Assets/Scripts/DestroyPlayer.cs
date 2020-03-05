﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject Timer;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            gameManager.SendMessage("OnPlayerDied");
            Timer.SendMessage("StopTimer");
        }
    }
}
