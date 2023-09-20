using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public float ribbitTimer = 2;
    public float frogDyingTimer = 7;
    public int bewitchedChildren  = 0;
    public GameObject frog;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            soundEffects.Instance.StepOnFrog();
            Destroy(gameObject);
            bewitchedChildren++;
    }

    private void Update()
    {
        ribbitTimer -= Time.deltaTime;
        frogDyingTimer -= Time.deltaTime;
        if ( frogDyingTimer < 0)
        {
            soundEffects.Instance.DisapepearingFrog();
            Destroy(gameObject);
            frogDyingTimer = 7;
        }
        if ( ribbitTimer < 0 )
        {
            soundEffects.Instance.FrogSound();
            ribbitTimer = 2;
        }

    }


}
