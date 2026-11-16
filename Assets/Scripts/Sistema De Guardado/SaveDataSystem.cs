using UnityEngine;
using System.IO;

public static class SaveDataSystem
{
    static string savePath = Application.persistentDataPath + "/SaveFile.save";

    public static void Save()
    {
        string json = JsonUtility.ToJson(Stats.userStats, true); //Cojemos el contenido de la variable userStats y lo convertimos a json;
        File.WriteAllText(savePath, json);
        Debug.Log("Saved at: " + savePath);
    }

    public static void Load()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            Stats.userStats = JsonUtility.FromJson<UserStats>(json);
            Debug.Log ("Data Loaded");
        }
        else
        {
            Debug.Log ("No Data to Load");
        }
    }
}
