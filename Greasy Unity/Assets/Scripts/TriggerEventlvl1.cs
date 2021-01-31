using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEventlvl1 : MonoBehaviour
{
    [SerializeField]
    GameHandler gameHandler;

    void Start()
    {
        gameHandler = GameObject.Find("Canvas").GetComponent<GameHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameSaver gameSaver = gameObject.GetComponent<GameSaver>();
        if (gameSaver != null)
        {
            gameSaver.addCoins(gameHandler.coins);
            gameSaver.WriteSaveFile();
        }
        else
        {
            Debug.LogError("Cannot find GameSaver Component");
        }

        SceneManager.LoadScene("lvl2");
        Debug.Log("Triggered");
    }
}
