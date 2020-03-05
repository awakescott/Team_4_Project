using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroyer : MonoBehaviour
{
    void Start()
    {
        Destroy(GameObject.Find("Timer"));
    }
}
