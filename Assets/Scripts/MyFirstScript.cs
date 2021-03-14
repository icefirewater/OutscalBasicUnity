﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Awake is called before Start Function
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    // FixedUpdate is called every 0.02 seconds
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
}
