using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float followSpeed = 0.5f;
    Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        SetTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            SetTarget();
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, followSpeed * Time.deltaTime);
    }

    void SetTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position, followSpeed * Time.deltaTime);
    }
}
