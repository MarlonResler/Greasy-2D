using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins = 0;

    [SerializeField]
    GameSaver gameSaver;
    // Start is called before the first frame update
    void Start()
    {
        //Load coins from save file
        this.coins = gameSaver.GetCoins();
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins: " + coins;
    }
}
