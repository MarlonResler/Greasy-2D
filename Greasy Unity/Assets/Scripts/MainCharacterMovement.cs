using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    [SerializeField]
    Transform transObj;

    bool menu;

    // Start is called before the first frame update
    void Start()
    {
        menu = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!menu)
        {
            transObj
                .Translate(Vector3.forward * Input.GetAxis("Horizontal") * 0.20f);
            if (Input.GetAxis("Vertical") > 0)
            {
                transObj
                    .Translate(Vector3.up * Input.GetAxis("Vertical") * 0.2f);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            menu = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu = false;
        }
    }
}
