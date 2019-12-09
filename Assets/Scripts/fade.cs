using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour
{

    public bool fading = false;
    public float ft = 1;

    void Fade()
    {

        Debug.Log("hola, estoy haciendo un fade");
        while (ft > 0)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;

            GetComponent<Renderer>().material.color = c;
            ft = ft - 0.01f;

        }


    }

    IEnumerator FadeCorrutina()
    {
        Debug.Log("hola, estoy haciendo un fade");
        while (ft > 0)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;

            GetComponent<Renderer>().material.color = c;
            ft = ft - 0.01f;
            yield return new WaitForSeconds(0.5f); ;
        }
    }

    void Update()
    {

        if (fading)
        {

            
            Fade();
            fading = false;


        }

    }
}
