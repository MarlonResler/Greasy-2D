using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement

public class neustart : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "maincharacter")
        {
            Debug.Log("maincharacter dead");
            SceneManager.LoadScene("scene00");
        }else
            Debug.Log("Its not the maincharacter")
    }
}
