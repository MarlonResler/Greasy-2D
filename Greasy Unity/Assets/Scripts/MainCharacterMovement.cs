using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterMovement : MonoBehaviour
{
    [SerializeField]
    Transform transObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transObj.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.20f);
        if (Input.GetAxis("Vertical") > 0)
        
        {
	transObj.Translate(Vector3.up * Input.GetAxis("Vertical") * 0.2f);

        }
    }
}
