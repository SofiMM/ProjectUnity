using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaraseguir : MonoBehaviour {

    public GameObject personaje;
    private Vector3 distancia;
    // Use this for initialization
    void Start () {
        distancia = transform.position - personaje.transform.position;
    }
    
    // Update is called once per frame
    
    void LateUpdate () {
        transform.position= personaje.transform.position + distancia;
        transform.position= personaje.transform.position + distancia;
        
       // transform.LookAt(personaje.transform.position);

       // Vector3 copiaRota = new Vector3(0, transform.eulerAngles.y, 0);
       // referencia.transform.eulerAngles = copiaRota;
    }
}