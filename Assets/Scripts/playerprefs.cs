using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs : MonoBehaviour
{
    private void Start()
    {

      //  PlayerPrefs.SetInt("tiempo", 16);

        if (PlayerPrefs.HasKey("tiempo"))
        {
            Debug.Log("si existe el tiempo guardado");
            Debug.Log(PlayerPrefs.GetInt("tiempo"));
        }

     
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        { 
        Debug.Log("seteando el tiempo");
        PlayerPrefs.SetInt("tiempo",15);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            
            Debug.Log("borrando los datos");
            //PlayerPrefs.DeleteAll();
            PlayerPrefs.DeleteKey("tiempo");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("cargando los datos");
            //PlayerPrefs.DeleteAll();
            Debug.Log(PlayerPrefs.GetInt("tiempo"));
        }
    }
}
