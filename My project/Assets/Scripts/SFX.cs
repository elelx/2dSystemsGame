using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioClip sound;   
    private AudioSource source;

    void Awake()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    public void PlaySound()
    {
        if (sound != null)
            source.PlayOneShot(sound);
    }
}
