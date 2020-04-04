﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshAgent : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
