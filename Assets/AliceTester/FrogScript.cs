using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FrogScript : MonoBehaviour
{

    public GameObject frog;

    public int score;
    float destroyDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "frog")
        {
            score += 1;
           

            Destroy(other.gameObject, destroyDelay);
            Debug.Log("hit");
        }
    }
}
