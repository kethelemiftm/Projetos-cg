﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenemaneger : MonoBehaviour
{
    [SerializeField]
   private Vector3 TapeSpeed = new Vector3(-2f, 0f, 0f);
   [SerializeField]
   private Transform Tape = null; 

   public UIcomponents uicomponents;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tape.position = Tape.position + TapeSpeed * Time.deltaTime;
    }
}
