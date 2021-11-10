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
            //�w�肵���X�s�[�h���猻�݂̑��x�������ĉ����͂����߂�
            float currentSpeed = speed - rb.velocity.magnitude;
            //�������ꂽ�����͂ŗ͂�������
            rb.AddForce(new Vector3(currentSpeed, 0, 0));
        }
    }// Update is called once per frame

}