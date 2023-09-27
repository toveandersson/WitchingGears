using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;

using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

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
        if (enemy != null && (enemy.gameObject.tag != "target" || enemy.gameObject.tag != "Props"))
        {
            enemy.DestroyEnemy();
        }
        TransformEnemyEffects();
        SpawnGroda();
        Destroy(other.gameObject);
        Destroy(gameObject, 0.01f);
        //TODO: add bottle crash animation
    }
    
    private void TransformEnemyEffects()
    {
        GameObject newExplosion = Instantiate(explosion, transform.position, transform.rotation);
        CameraMovement.Instance.ShakeCamera(3f, 0.1f);
        SoundEffects.Instance.Kaboom();
        Destroy(newExplosion, 0.5f);
    }

    private void SpawnGroda()
    {
        Quaternion noRotation = Quaternion.identity;
        GameObject newGroda = Instantiate(groda, transform.position, noRotation);
    }
}
