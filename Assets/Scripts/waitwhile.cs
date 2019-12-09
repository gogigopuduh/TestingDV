﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitwhile : MonoBehaviour
{
    public int frame;

    void Start()
    {
        StartCoroutine(EsperaMientras());
    }

    IEnumerator EsperaMientras()
    {
        Debug.Log("esperando a que se cumpla la condicion");
        yield return new WaitWhile(() => frame < 10);
        Debug.Log("termino!!! y espero a que terminara de contar 10 frames");
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
