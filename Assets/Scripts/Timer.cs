using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    private float time;
    bool playTimer = true;
    public bool canTime;
    public GameObject rootCanvas;

    public void Start()
    {
        canTime = true;
        DontDestroyOnLoad(rootCanvas);
    }

    void Update()
    {
        if (canTime == true)
        {
            time += Time.deltaTime;
        }

        int minutes = Mathf.FloorToInt(time / 60); //Divide the guiTime by sixty to get the minutes.
        int seconds = Mathf.FloorToInt(time % 60); //Use the euclidean division for the seconds.
        int fraction = Mathf.FloorToInt((time * 100) % 100);

        if (playTimer == true && canTime == true)
        {
            //update the label value
            //timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
            timerLabel.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + fraction.ToString("00");
        }
    }

    void StopTimer()
    {

        canTime = false;

    }
}
