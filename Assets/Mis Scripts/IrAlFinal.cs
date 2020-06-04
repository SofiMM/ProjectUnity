using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrAlFinal : MonoBehaviour
{
    public static int planetas=0;
    public static int OpenTheDoor=0;
    public GameObject arbol;
    public GameObject Puerta1; public GameObject Bola1;
    public GameObject Puerta2; public GameObject Bola2;
    public GameObject Puerta3; public GameObject Bola3;
    public GameObject Puerta4; public GameObject Bola4;
    public GameObject Puerta5; public GameObject Bola5;
    public GameObject Puerta7; public GameObject Bola7;
    public GameObject Puerta6;
    public GameObject Bola6;
    public GameObject Bola8;
    public GameObject Bola9;
    public GameObject Bola10;
    public GameObject Bola11;
    // Start is called before the first frame update
    void Start()
    {
        planetas=0;
        arbol.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
        {
        if (gameObject.tag == "Jugador")
        { // Interacting ONLY with the First Person Controller
            if (other.gameObject.tag == "Bola1") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola1);
                Destroy(Puerta1);
                }
            if (other.gameObject.tag == "Bola2") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola2);
                Destroy(Puerta2);
                }
            if (other.gameObject.tag == "Bola3") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola3);
                Destroy(Puerta3);
                }
            if (other.gameObject.tag == "Bola4") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola4);
                Destroy(Puerta4);
            }
            if (other.gameObject.tag == "Bola5") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola5);
                Destroy(Puerta5);
            }
            if (other.gameObject.tag == "Bola7") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(Bola7);
                Destroy(Puerta7);
            }
            if (other.gameObject.tag == "Bola6") {
                planetas=planetas+1;
                OpenTheDoor=OpenTheDoor+1;
                Destroy(Bola6);
                print("planetas: "+planetas);
            }
            if (other.gameObject.tag == "Bola8") {
                planetas=planetas+1;
                OpenTheDoor=OpenTheDoor+1;
                Destroy(Bola8);
                print("planetas: "+planetas);
            }
            if (other.gameObject.tag == "Bola9") {
                planetas=planetas+1;
                Destroy(Bola9);
                print("planetas: "+planetas);
            }
            if (other.gameObject.tag == "Bola10") {
                planetas=planetas+1;
                Destroy(Bola10);
                print("planetas: "+planetas);
            }
            if (other.gameObject.tag == "Bola11") {
                planetas=planetas+1;
                Destroy(Bola11);
                print("planetas: "+planetas);
            }
        } 
    }

    void LateUpdate()
    { // To update the position of the camera AFTER the update of the sphere
        if(planetas>=8){
            arbol.SetActive(true);
        }
        if(OpenTheDoor==2){
            Destroy(Puerta6);
        }
    }
}
