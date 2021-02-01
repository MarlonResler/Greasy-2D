using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class GameSaver : MonoBehaviour
{
    SaveFile save;

    //Run before the Start Method of the Coin Loader
    void Awake()
    {
        save = SaveFileSerializer.OpenSaveFile();
    }

    public void addCoins(int coins)
    {
        if (save != null)
        {
            save.SetCoins (coins);
            Debug.Log("Saved Coins. New value: " + save.GetCoins());
        }
        else
        {
            Debug.LogError("Save file not assigned");
        }
    }

    public void WriteSaveFile()
    {
        SaveFileSerializer.WriteSaveFile(this.save);
    }

    public int GetCoins()
    {
        return save.GetCoins();
    }

    public bool setActiveSkin(string skin)
    {
        bool isSkinActivated = save.setActiveSkin(skin);
        SaveFileSerializer.WriteSaveFile(this.save);
        return isSkinActivated;
    }

    public string getActiveSkin(){
        return save.getActiveSkin();
    }
}

public static class SaveFileSerializer
{
    private static string FILE_PATH = "saveFile.json";

    public static SaveFile OpenSaveFile()
    {
        try
        {
            StreamReader sr =
                new StreamReader(File
                        .Open(SaveFileSerializer.FILE_PATH,
                        System.IO.FileMode.OpenOrCreate,
                        FileAccess.Read));
            SaveFile save =
                JsonConvert.DeserializeObject<SaveFile>(sr.ReadToEnd());
            if (save != null)
            {
                Debug.Log("Successfully opened Save File");
            }
            else
            {
                Debug.Log("Got empty json String. Using empty Save file class");
                save = new SaveFile();
            }
            sr.Close();
            return save;
        }
        catch (System.Exception e)
        {
            Debug.LogError (e);
            return new SaveFile();
        }
    }

    public static void WriteSaveFile(SaveFile save)
    {
        StreamWriter sw;
        try
        {
            sw =
                new StreamWriter(File
                        .Open(FILE_PATH, System.IO.FileMode.Create));
        }
        catch (System.Exception e)
        {
            Debug.LogError (e);
            return;
        }

        try
        {
            string json = JsonConvert.SerializeObject(save);
            Debug.Log (json);
            sw.Write (json);
        }
        catch (System.Exception e)
        {
            Debug.LogError (e);
            return;
        }
        sw.Close();
    }
}

public class SaveFile
{
    [JsonProperty]
    private Dictionary<string, bool> skins;

    [JsonProperty]
    private int coins;

    [JsonProperty]
    private string activeSkin;

    public SaveFile()
    {
        this.skins = new Dictionary<string, bool>();
        skins.Add("Black", true);
        skins.Add("Bacon", false);
        skins.Add("Guy", false);
        skins.Add("Dog", false);
        skins.Add("Mario", false);
        skins.Add("Cat", false);

        this.coins = 0;

        this.activeSkin = "Black";
    }

    public void ActivateSkin(string skin)
    {
        this.skins[skin] = true;
    }

    public void SetCoins(int coinsReached)
    {
        this.coins = coinsReached;
    }

    public int GetCoins()
    {
        return this.coins;
    }

    public bool setActiveSkin(string skin)
    {
        Debug.Log("Trying to load skin: " + skin + this.skins[skin]);
        if (this.skins[skin])
        {
            this.activeSkin = skin;
            Debug.Log("Set active skin to: " + skin);
            return true;
        }
        else if (this.coins > 4)
        {
            this.skins[skin] = true;
            this.activeSkin = skin;
            this.coins -= 5;
            Debug
                .Log("Buy and set active skin to: " +
                skin +
                "\nNew coin value: " +
                this.coins);
            return true;
        }
        else
        {
            Debug.LogWarning("Not enough coins");
            return false;
        }
    }

    public string getActiveSkin(){
        return this.activeSkin;
    }
}
