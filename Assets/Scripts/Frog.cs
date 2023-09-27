using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Frog : MonoBehaviour
{    
    public GameObject frogPop;   
    public GameObject frog;

    public float ribbitTimer = 2;
    public float frogDyingTimer = 7;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<BigExplotion>();         
        SoundEffects.Instance.StepOnFrog();
        Destroy(gameObject);
        GameObject newfrogpop = Instantiate(frogPop, transform.position, Quaternion.identity);
        Destroy(newfrogpop, 0.4f);
    }

    private void Update()
    {
        ribbitTimer -= Time.deltaTime;
        frogDyingTimer -= Time.deltaTime;

        if ( frogDyingTimer < 0)
        {
            FrogDying();
        }

        if ( ribbitTimer < 0 )
        {
            FrogRibbit();
        }
    }

    private void FrogDying()
    {
        SoundEffects.Instance.DisapepearingFrog();
        Destroy(gameObject);
        frogDyingTimer = 7;
        Quaternion noRotation = Quaternion.identity;
        GameObject popAnimation = Instantiate(frogPop, transform.position, noRotation);
        Destroy(popAnimation, 0.4f);
    }

    private void FrogRibbit()
    {
        SoundEffects.Instance.FrogSound();
        ribbitTimer = 2;
    }
}
