using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public int powerUpPoints = 0;
    public GameObject powerupArea;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundEffects.Instance.PowerUp();
        Debug.Log("trigger!");
        powerUpPoints++;
    }
}
