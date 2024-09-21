using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Volver_Menu : MonoBehaviour
{
    
    public void Volver()
    {
        SceneManager.LoadScene("INICIO", LoadSceneMode.Single);
    }
    public void Jugar()
    {
        SceneManager.LoadScene("1-1", LoadSceneMode.Single);
        PlayerPrefs.DeleteAll(); 

    }
    public void Salir()
    {
        Debug.Log("Salir...");
    }
}
