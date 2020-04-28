using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class InterfaceAwake : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("PrimeraPantalla");
    }
    public void Salir()
    {
         Application.Quit();
    }
}
