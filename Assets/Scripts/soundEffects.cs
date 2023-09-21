using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour
{
    public static soundEffects Instance { get; private set; }
    private AudioSource source;
    public AudioClip disappearingFrog;
    public AudioClip ultimateSound;
    public AudioClip[] kaboom;
    public AudioClip[] powerup;
    public AudioClip[] evillaugh;
    public AudioClip[] frogsound;
    public AudioClip[] steponfrog;
    public float laughTimer = 5;
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

    public void Kaboom()
    {
        //randomize a soundclip from the kaboom list and play without interruption when called
        int i = Random.Range(0, kaboom.Length);
        source.clip = kaboom[i];
        source.PlayOneShot(source.clip);
    }
    public void PowerUp()
    {
        //randomize a soundclip from the powerup list and play without interruption when called
        int i = Random.Range(0, powerup.Length);
        source.clip = powerup[i];
        source.PlayOneShot(source.clip);
    }
    public void EvilLaugh()
    {
        //randomize a soundclip from the evillaugh list and play without interruption when called
        int i = Random.Range(0, evillaugh.Length);
        source.clip = evillaugh[i];
        source.PlayOneShot(source.clip);
    }
    public void FrogSound()
    {
        //randomize a soundclip from the frogsound list and play without interruption when called
        int i = Random.Range(0, frogsound.Length);
        source.clip = frogsound[i];
        source.PlayOneShot(source.clip);
    }
    public void StepOnFrog()
    {
        //randomize a soundclip from the steponfrog list and play without interruption when called
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

}
