using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrutina : MonoBehaviour
{ 
//se define siempre con un yield return, es necesario decir cuando termina la corrutina


    //se define bajo un IEnumerator
    //se lanza con un StartCoroutine
    //se detiene cuando captura el return o cuando fuerza la detencion con un stop
    //las condiciones mas usadas son WaitForSeconds, WaitWhile, WaitUntil
    //incluso lanzar la misma corrutina

    IEnumerator CorrutinaTest()
    {
        Debug.Log("hola soy un corrutina");
        
        yield return 0;// puede ser null o 0 es decir, no nos interesa que devuelva algo
    }

    private void Start()
    {
        StartCoroutine(CorrutinaTest());
    }
}
