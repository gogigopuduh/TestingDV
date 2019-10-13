using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            Debug.Log("tocando al objeto "+hit.collider.name);

            if (Input.GetMouseButtonDown(0))
            {
                Destroy(hit.collider.gameObject);
            }
        }

    }
}
