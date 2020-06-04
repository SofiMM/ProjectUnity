using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
    {//"Segunda_plataforma"
        if (other.tag == "Jugador"){
            SceneManager.LoadScene("Final");
        }   
    }
}
