using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
  

    private int BulletSpeed = 10;
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * BulletSpeed * Time.deltaTime);
        Destroy(gameObject, 1f);

    }
}
