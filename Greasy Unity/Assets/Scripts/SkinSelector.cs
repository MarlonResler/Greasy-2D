using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelector : MonoBehaviour
{
    [SerializeField]
    List<Material> skinMats;

    GameSaver gameSaver;

    GameObject mainCharacter;

    RectTransform transform;

    GameHandler ui;

    void Start()
    {
        transform = gameObject.GetComponent<RectTransform>();
        gameSaver =
            GameObject
                .FindGameObjectsWithTag("CoinLoader")[0]
                .GetComponent<GameSaver>();
        mainCharacter = GameObject.FindGameObjectsWithTag("MainCharacter")[0];
        ui = GameObject.FindGameObjectsWithTag("CoinUI")[0].GetComponent<GameHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(transform.localPosition.x);
            if (transform.localPosition.x >= 190)
            {
                transform.localPosition += Vector3.left * 400;
            }
            else
            {
                transform.localPosition += Vector3.right * 200;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(transform.localPosition.x);
            if (transform.localPosition.x <= -190)
            {
                transform.localPosition += Vector3.right * 400;
            }
            else
            {
                transform.localPosition += Vector3.left * 200;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(transform.localPosition.y);
            if (transform.localPosition.y <= -90)
            {
                transform.localPosition += Vector3.up * 175;
            }
            else
            {
                transform.localPosition += Vector3.down * 175;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(transform.localPosition.y);
            if (transform.localPosition.y >= 70)
            {
                transform.localPosition += Vector3.down * 175;
            }
            else
            {
                transform.localPosition += Vector3.up * 175;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Choose Skin: " + getChoosedSkin().ToString());
            if (gameSaver.setActiveSkin(getChoosedSkin().ToString()))
            {
                mainCharacter.GetComponent<MeshRenderer>().material =
                    skinMats[(int) getChoosedSkin()];
                    ui.coins = gameSaver.GetCoins();
            }
        }
    }

    private SkinToInt getChoosedSkin()
    {
        switch (transform.localPosition.x)
        {
            case -200:
                if (transform.localPosition.y < 0)
                {
                    return SkinToInt.Dog;
                }
                else
                {
                    return SkinToInt.Black;
                }
                break;
            case 0:
                if (transform.localPosition.y < 0)
                {
                    return SkinToInt.Cat;
                }
                else
                {
                    return SkinToInt.Guy;
                }
                break;
            case 200:
                if (transform.localPosition.y < 0)
                {
                    return SkinToInt.Bacon;
                }
                else
                {
                    return SkinToInt.Mario;
                }
                break;
            default:
                return SkinToInt.Error;
        }
    }

    public enum SkinToInt
    {
        Error = -1,
        Black = 0,
        Dog = 1,
        Cat = 2,
        Guy = 3,
        Bacon = 4,
        Mario = 5
    }
}
