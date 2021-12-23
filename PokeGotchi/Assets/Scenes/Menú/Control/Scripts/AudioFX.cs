using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip botonFx;
    
    public void ClickSound()
    {
        myFx.PlayOneShot(botonFx);
    }
}
