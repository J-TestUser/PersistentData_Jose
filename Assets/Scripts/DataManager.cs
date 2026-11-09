using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public string nombreUsuario;
    public int vitalidad;
    public int fuerza;
    public int destreza;
    public int inteligencia;
    public float experiencia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        //LoadData();  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
    }

    /*void SaveData()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad);
        PlayerPrefs.SetInt("FuerzaPersonaje", fuerza);
        PlayerPrefs.SetInt("DestrezaPersonaje", destreza);
        PlayerPrefs.SetInt("InteligenciaPersonaje", inteligencia);
        PlayerPrefs.SetFloat("ExperienciaUsuario", experiencia);
    }

    void LoadData()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        fuerza = PlayerPrefs.GetInt("FuerzaPersonaje", 4);
        destreza = PlayerPrefs.GetInt("DestrezaPersonaje", 2);
        inteligencia = PlayerPrefs.GetInt("InteligenciaPersonaje", 5);        
        experiencia = PlayerPrefs.GetFloat("ExperienciaUsuario", 0.5f);
    }*/

    void SaveData()
    {
        PlayerData.nombreUsuario = nombreUsuario;
        PlayerData.vitalidad = vitalidad;
        PlayerData.fuerza = fuerza;
        PlayerData.destreza = destreza;
        PlayerData.inteligencia = inteligencia;
        PlayerData.experiencia = experiencia;

        PlayerData.Save();
    }

    void LoadData()
    {
        PlayerData.Load();

        nombreUsuario = PlayerData.nombreUsuario;
        vitalidad = PlayerData.vitalidad;
        fuerza = PlayerData.fuerza;
        destreza = PlayerData.destreza;
        inteligencia = PlayerData.inteligencia;
        experiencia = PlayerData.experiencia;
    }
}
