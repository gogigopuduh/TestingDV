using UnityEngine;
using System.Collections;

public class colision_enter : MonoBehaviour
{
  

    void Start()
    {
       
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "cubo2")
        {
            Debug.Log("se cambio el color del objeto de la colision detectada");
            col.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}