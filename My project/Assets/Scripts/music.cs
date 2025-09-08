using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{

    [SerializeField] private AudioClip musicClip; 

    void Awake()
    {
        DontDestroyOnLoad(gameObject);   

        AudioSource audio = GetComponent<AudioSource>();

        if (audio == null) audio = gameObject.AddComponent<AudioSource>();

        audio.clip = musicClip;
        audio.loop = true;
        audio.Play();
    }
}
