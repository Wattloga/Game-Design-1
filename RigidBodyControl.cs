﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyControl : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);

        Vector3 movement = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);

        rb.MovePosition(transform.position + movement);
    }
}
