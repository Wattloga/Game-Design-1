﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        
        Debug.Log("Welcome to Number wizard");
        Debug.Log("Pick a number, and don't reveal the answer...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Is your number higher or lower than 500");
        Debug.Log("Click Up = higher, Click Down = lower, Click Enter = CORRECT!");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed.");
        }    
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return arrow was pressed");
        }
    }
}
