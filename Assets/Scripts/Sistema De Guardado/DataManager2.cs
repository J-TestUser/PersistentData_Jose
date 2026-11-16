using UnityEngine;

public class DataManager2 : MonoBehaviour
{
    public string playerName;
    public Vector3 playerPosition;
    public float playerHealth;
    public int playerExp;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
    }

    void SaveData()
    {
        Stats.userStats.playerName = playerName;
        Stats.userStats.playerPosition = playerPosition;
        Stats.userStats.playerHealth = playerHealth;
        Stats.userStats.playerExp = playerExp;

        SaveDataSystem.Save();
    }

    void LoadData()
    {
        SaveDataSystem.Load();

        playerName = Stats.userStats.playerName;
        playerPosition = Stats.userStats.playerPosition;
        playerHealth = Stats.userStats.playerHealth;
        playerExp = Stats.userStats.playerExp;

    }
}
