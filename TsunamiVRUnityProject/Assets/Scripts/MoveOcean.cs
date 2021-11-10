using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOcean : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.velocity.magnitude < 10)
        {
            //指定したスピードから現在の速度を引いて加速力を求める
            float currentSpeed = speed - rb.velocity.magnitude;
            //調整された加速力で力を加える
            rb.AddForce(new Vector3(currentSpeed, 0, 0));
        }
    }// Update is called once per frame

}