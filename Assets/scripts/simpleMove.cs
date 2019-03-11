﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;
        void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        float So = transform.position.x;
        float S = So + horizontalInput * SpeedFactor * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
