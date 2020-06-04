using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerPlanetas : MonoBehaviour
{
   // Only ONE class to control all the stones
    private Rigidbody rigidBody; private Vector3 offset; // The distance
    private bool following = false; public GameObject target; // The target to follow
    public static int planetas=0; public GameObject arbol;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>(); offset = gameObject.transform.position - target.transform.position;
        if(planetas!=21){
            arbol.SetActive(false);

        }
    }

     void OnCollisionEnter(Collision other)
        {
        if (other.gameObject.tag == "Jugador")
        { // Interacting ONLY with the First Person Controller
            if (gameObject.tag == "Bola") {
                planetas=planetas+1;
                print("planetas: "+planetas);
                Destroy(gameObject); }
        } 
    }

    void LateUpdate()
    { // To update the position of the camera AFTER the update of the sphere
        if(planetas>=11){
            arbol.SetActive (true);
        }
    }
}
