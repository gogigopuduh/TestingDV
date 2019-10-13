using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_enter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "cubo2")
        {
            Debug.Log("objeto destruido con trigger enter");
            Destroy(col.gameObject);
        }

        
    }
}
