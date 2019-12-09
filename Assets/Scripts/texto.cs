using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class texto : MonoBehaviour
{
    public InputField input;
    public string n;


    public void Boton()
    {
       n = input.text;
        Debug.Log(n);
    }
}
