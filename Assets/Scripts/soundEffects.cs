using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static SoundEffects Instance { get; private set; }
    
    private AudioSource source;

    public AudioClip disappearingFrog;
    public AudioClip ultimateSound;

    public AudioClip[] kaboom;
    public AudioClip[] powerup;
    public AudioClip[] evillaugh;
    public AudioClip[] frogsound;
    public AudioClip[] steponfrog;
    public AudioClip[] eating;

    private float laughTimer = 5;

    private void Awake()
    {
        Instance = this;
        source = GetComponent<AudioSource>();

    }

    private void Update()
    {
        laughTimer -= Time.deltaTime;
        if (laughTimer < 0)
        {
            EvilLaugh();
            laughTimer = 5;
        }
    }

    public void EvilLaugh()
    {
        int i = Random.Range(0, evillaugh.Length);
        source.clip = evillaugh[i];
        source.PlayOneShot(source.clip);
    }

    public void Kaboom()
    {
        //randomize a soundclip from the kaboom list and play without interruption when called
        int i = Random.Range(0, kaboom.Length);
        source.clip = kaboom[i];
        source.PlayOneShot(source.clip);
    }

    public void PowerUp()
    {
        int i = Random.Range(0, powerup.Length);
        source.clip = powerup[i];
        source.PlayOneShot(source.clip);
    }

    public void FrogSound()
    {
        int i = Random.Range(0, frogsound.Length);
        source.clip = frogsound[i];
        source.PlayOneShot(source.clip);
    }

    public void StepOnFrog()
    {
        int i = Random.Range(0, steponfrog.Length);
        source.clip = steponfrog[i];
        source.PlayOneShot(source.clip);
    }

    public void DisapepearingFrog()
    {
        source.clip = disappearingFrog;
        source.PlayOneShot(source.clip);
    }

    public void Ultimate()
    {
        source.clip = ultimateSound;
        source.volume = source.volume * 5f;
        source.PlayOneShot(source.clip);
    }

    public void Eating()
    {
        int i = Random.Range(0, eating.Length);
        source.clip = eating[i];
        source.PlayOneShot(source.clip);
    }
}
