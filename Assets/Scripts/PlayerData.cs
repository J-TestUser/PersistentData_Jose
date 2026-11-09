using UnityEngine;

public static class PlayerData
{
    public static string nombreUsuario;
    public static int vitalidad;
    public static int fuerza;
    public static int destreza;
    public static int inteligencia;
    public static float experiencia;
    public static Vector3 lastPosition;

    public static void Save()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad);
        PlayerPrefs.SetInt("FuerzaPersonaje", fuerza);
        PlayerPrefs.SetInt("DestrezaPersonaje", destreza);
        PlayerPrefs.SetInt("InteligenciaPersonaje", inteligencia);
        PlayerPrefs.SetFloat("ExperienciaUsuario", experiencia);
    }

    public static void Load()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        fuerza = PlayerPrefs.GetInt("FuerzaPersonaje", 4);
        destreza = PlayerPrefs.GetInt("DestrezaPersonaje", 2);
        inteligencia = PlayerPrefs.GetInt("InteligenciaPersonaje", 5);        
        experiencia = PlayerPrefs.GetFloat("ExperienciaUsuario", 0.5f);
    }
}