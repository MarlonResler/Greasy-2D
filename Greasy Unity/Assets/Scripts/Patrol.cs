using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patrol : MonoBehaviour
{
    public float delta = 1.5f; // Amount to move left and right from the start point

    public float speed = 2.0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Triggered");
    }
}
