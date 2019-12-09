using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waituntil : MonoBehaviour
{
    public int frame;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        Debug.Log("esperando hasta que se cumpla la condicion");
        yield return new WaitUntil(() => frame >= 10);
        Debug.Log("Termino!!! se cumplio la condicion de frames = 10");
    }

    void Update()
    {
        if (frame <= 10)
        {
            Debug.Log("Frame: " + frame);
            frame++;
        }
    }
}
