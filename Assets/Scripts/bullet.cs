using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;

public class bullet : MonoBehaviour
{
    public GameObject explosion;
    public GameObject groda;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public float bulletSpeed = 10;


    void Start()
    {
        Destroy(gameObject, 10);
    }
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        transform.Rotate(0, 0, 10*Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();

        if (enemy != null && enemy.gameObject.tag != "target")
        {
            // Call the DestroyEnemy() method on the enemy script
            enemy.DestroyEnemy();
        }
        //Create a new explosion and save that explosion in a variable. +shake the camera with soundeffect
        GameObject newExplosion = Instantiate(explosion, transform.position, transform.rotation);
        cameraMovement.Instance.ShakeCamera(5f, 0.1f);
        soundEffects.Instance.Kaboom();
        Quaternion noRotation = Quaternion.identity;
        GameObject newGroda = Instantiate(groda, transform.position, noRotation);

        //Destroy the newly created explosion object after 1 second.
        Destroy(newExplosion, 1);

        //Ha en gå sönder animation här också sen

        Invoke("death", 0.01f);

        Destroy(other.gameObject);

        
    }


    void death()
    {
        Destroy(gameObject);
    }
    
}
