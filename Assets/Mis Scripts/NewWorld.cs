using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewWorld : MonoBehaviour
{       
    void OnTriggerEnter(Collider other)
    {//"Segunda_plataforma"
        if (other.tag == "Jugador"){
            SceneManager.LoadScene("Segunda_plataforma");
        }   
    }
}
