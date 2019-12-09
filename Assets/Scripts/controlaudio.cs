using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaudio : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] biblioteca;

    private void Start()
    {
        audio.clip = biblioteca[0];
        audio.Play();
    }
}
