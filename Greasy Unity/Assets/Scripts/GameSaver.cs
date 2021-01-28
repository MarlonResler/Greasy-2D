
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameSaver : MonoBehaviour {
    SaveFile save;
    void Start(){
        save = SaveFileSerializer.OpenSaveFile();

    }

    public void addCoins(int coins){
        if (save != null)
        {
            save.SetCoins(coins);
            Debug.Log("Saved Coins. New value: " + save.GetCoins());
        } else {
            Debug.LogError("Save file not assigned");
        }
        
    }
}

public static class SaveFileSerializer{
    private static string FILE_PATH = "saveFile.json";
    public static SaveFile OpenSaveFile(){
        try
        {
            StreamReader sr = new StreamReader(File.Open(SaveFileSerializer.FILE_PATH, System.IO.FileMode.OpenOrCreate, FileAccess.Read));
            SaveFile save = JsonUtility.FromJson<SaveFile>(sr.ReadToEnd());
            Debug.Log("Successfully opened Save File");
            return save;
        }
        catch (System.Exception e)
        {            
            Debug.LogError(e);
            return new SaveFile();
        }
    }

    public static void WriteSaveFile(string jsonString){
        StreamWriter sw;
        try
        {
            sw = new StreamWriter(File.Open(FILE_PATH, System.IO.FileMode.Append));
        }
        catch (System.Exception e)
        {
            
            Debug.LogError(e);
            return;
        }

        sw.Write(JsonUtility.ToJson(jsonString));
    }
}

public class SaveFile {
    private Dictionary<string, bool> skins;
    private int coins;

    public SaveFile() {
        this.skins = new Dictionary<string, bool>();
        skins.Add("Black", false);
        skins.Add("Bacon", false);
        skins.Add("Merkel", false);
        skins.Add("Dog", false);
        skins.Add("Mario", false);

        this.coins = 0;
    }

    public void ActivateSkin(string skin){
        this.skins[skin] = true;
    }

    public void SetCoins(int coinsReached){
        this.coins += coinsReached;
    }

    public int GetCoins(){
        return this.coins;
    }
}