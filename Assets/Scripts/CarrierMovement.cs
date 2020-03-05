using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrierMovement : MonoBehaviour
{
    // Set Variables
    public float minSpeed;
    public float maxSpeed;

    public float speed;

    public float changeSpeed;

    float initialSpeed;
    float targetSpeed;

    Vector2 targetPosition;

    public AnimationCurve animationCurve;

    // Use this for initialization
    void Start()
    {
        ChooseNewTargetPosition();

        initialSpeed = 0;
        speed = 0;

        ResetTimer();

        SetNewTargetSpeed();
    }

    // Update is called once per frame
    // Update the ghosts' positioning and speed everytime the timer resets
    void Update()
    {
        float timeElapsed = Time.time;
        float percent = timeElapsed / changeSpeed;

        if (percent > 1)
        {
            SetNewTargetSpeed();
            percent = 0;
            ResetTimer();
        }

        speed = Mathf.Lerp(initialSpeed, targetSpeed, animationCurve.Evaluate(percent));

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < .1f)
        {
            ChooseNewTargetPosition();
        }
    }

    // Reset the timer when a new target speed is found
    void ResetTimer()
    {
        SetNewTargetSpeed();
    }

    // Set a new target speed for the ghosts
    void SetNewTargetSpeed()
    {
        initialSpeed = targetSpeed;
        targetSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Choose a new position within the camera/screen for the ghosts to go
    void ChooseNewTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(Screen.width / 2, Screen.width), Random.Range(0, Screen.height)));
    }
}
