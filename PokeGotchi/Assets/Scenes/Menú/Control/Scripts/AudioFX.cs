using UnityEngine;

public class AudioFX : MonoBehaviour
{

    public AudioSource myFx;
    public AudioSource otherFx1;
    public AudioSource otherFx2;
    public AudioSource otherFx3;
    public AudioClip botonFx;

    public void ClickSound()
    {
        
        if (!myFx.isPlaying) {
        myFx.PlayOneShot(botonFx);
        }

        if (myFx.isPlaying)
        {
            otherFx1.Stop();
            otherFx2.Stop();
            otherFx3.Stop();
        }

    }

    
}
