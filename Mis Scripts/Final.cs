using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Final : MonoBehaviour
{
    public void GoToStart()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Salir()
    {
         Application.Quit();
    }
}
