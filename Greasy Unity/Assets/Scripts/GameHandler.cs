using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    Dictionary<string, Material> skinMats;
    public Text CoinText;
    public int coins = 0;

    [SerializeField]
    GameSaver gameSaver;

    [SerializeField]
    Material black;
    [SerializeField]
    Material guy;
    [SerializeField]
    Material bacon;
    [SerializeField]
    Material mario;
    [SerializeField]
    Material dog;
    [SerializeField]
    Material cat;

    
    // Start is called before the first frame update
    void Start()
    {
        skinMats = new Dictionary<string, Material>();
        skinMats.Add("Black", black);
        skinMats.Add("Guy", guy);
        skinMats.Add("Bacon", bacon);
        skinMats.Add("Mario", mario);
        skinMats.Add("Dog", dog);
        skinMats.Add("Cat", cat);

        //Load coins from save file
        this.coins = gameSaver.GetCoins();
        Debug.Log("Loading Coins: " + gameSaver.GetCoins());

        GameObject mainCharacter = GameObject.FindGameObjectsWithTag("MainCharacter")[0];
        mainCharacter.GetComponent<MeshRenderer>().material = skinMats[gameSaver.getActiveSkin()];
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins: " + coins;
    }
}
