using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEventlvl1 : MonoBehaviour
{
    [SerializeField]
    GameSaver gameSaver;
    GameHandler gameHandler;

    private void OnTriggerEnter(Collider other)
    {
        gameSaver.addCoins(gameHandler.coins);
        SceneManager.LoadScene("lvl2");
        Debug.Log("Triggered");
    }
}
