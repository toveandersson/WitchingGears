using System.Collections;
using System.Collections.Generic;
using System.Resources;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Frog : MonoBehaviour
{    
    public float ribbitTimer = 2;
    public float frogDyingTimer = 7;
    public GameObject frogPop;   
    public GameObject frog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<bigExplotion>();         
        soundEffects.Instance.StepOnFrog();
        GameObject newfrogpop = Instantiate(frogPop, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(newfrogpop, 0.4f);
        //animation
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
            Quaternion noRotation = Quaternion.identity;
            GameObject popAnimation = Instantiate(frogPop, transform.position, noRotation);
            Destroy(popAnimation, 0.4f);
        }

        if ( ribbitTimer < 0 )
        {
            soundEffects.Instance.FrogSound();
            ribbitTimer = 2;
        }

    } 


}
