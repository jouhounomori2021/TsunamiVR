using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 force = new Vector3(352.5f, 0.0f, 0.0f);
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider other)
    {
        rb.AddForce(force);
    }
}