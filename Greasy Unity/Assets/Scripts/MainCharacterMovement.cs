﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    [SerializeField]
    Transform transObj;

    [SerializeField]
    Rigidbody rig;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transObj.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.1f);
        if (Input.GetAxis("Vertical") > 0)
        {
            transObj.Translate(Vector3.up * Input.GetAxis("Vertical") * 0.05f);
        }
    }
}
