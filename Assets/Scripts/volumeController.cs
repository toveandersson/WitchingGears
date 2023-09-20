using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeController : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicVolume = 0.5f;
    void Awake()
    {
        AudioSource.Play();
    }

    void Update()
    {
        AudioSource.volume = musicVolume;
    }
    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }
}
