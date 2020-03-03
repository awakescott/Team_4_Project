using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    private float PlayerSpeed = 3;

    private Rigidbody2D PlayerBody;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {

        PlayerBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput * PlayerSpeed;
    }

    void FixedUpdate()
    {

        PlayerBody.MovePosition(PlayerBody.position + moveVelocity * Time.fixedDeltaTime);


    }
}
