using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Jugador"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }   
    }
}
