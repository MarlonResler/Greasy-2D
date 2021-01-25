
public static class SaveFileSerializer{
    private string filePath = "saveFile.json";
    public SaveFile OpenSaveFile(){
        try
        {
            StreamWriter sw = new StreamWriter(File.Open(this.filePath, System.IO.FileMode.Append))
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public SaveFile Deserialize(){

    }

    public string Serialize(SaveFile save){

    }

    public void WriteSaveFile(string jsonString){
        try
        {
            StreamWriter sw = new StreamWriter(File.Open(this.filePath, System.IO.FileMode.Append))
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}

public class SaveFile {
    private Dictionary<string, bool> skins;
    private int coins;

    SaveFile(){
        this skins = new Dictionary<string, bool>();
        skins.Add("Black", false);
        skins.Add("Bacon", false);
        skins.Add("Merkel", false);
        skins.Add("Dog", false);
        skins.Add("Mario", false);
    }

    ActivateSkin(string skin){
        this.skins[skin] = true;
    }

    SetCoins(int coinsReached){
        this.coins += coinsReached;
    }
}