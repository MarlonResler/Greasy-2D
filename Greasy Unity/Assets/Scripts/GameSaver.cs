
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class SaveFileSerializer{
    private static string FILE_PATH = "saveFile.json";
    public static SaveFile OpenSaveFile(){
        try
        {
            StreamReader sr = new StreamReader(File.Open(SaveFileSerializer.FILE_PATH, System.IO.FileMode.Append));
            SaveFile save = JsonUtility.FromJson<SaveFile>(sr.ReadToEnd());
            return save;
        }
        catch (System.Exception)
        {
            
            throw;
            return new SaveFile();
        }
    }

    public static SaveFile Deserialize(){
        
    }

    public static string Serialize(SaveFile save){

    }

    public static void WriteSaveFile(string jsonString){
        StreamWriter sw;
        try
        {
            sw = new StreamWriter(File.Open(this.filePath, System.IO.FileMode.Append));
        }
        catch (System.Exception)
        {
            
            throw;
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

    void ActivateSkin(string skin){
        this.skins[skin] = true;
    }

    void SetCoins(int coinsReached){
        this.coins += coinsReached;
    }
}