using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Final : MonoBehaviour
{
    public void GoToStart()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
         Application.Quit();
    }
}
