using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public float timer = 0;
    public GameObject gumma;
    public GameObject bullet;
    private Vector2 spawnPos;
    public static GameObject enemy01;
    public static GameObject enemy02;
    public static GameObject enemy03;
    public static GameObject enemy04;

    public GameObject[] enemies = { enemy01, enemy02, enemy03, enemy04 };
    
    void Start()
    {
    }

    void SpawnEnemy()
    {
        //choose a random spot to spawn enemy at
        spawnPos = UnityEngine.Random.insideUnitCircle;
        spawnPos.Normalize();
        //choose a random enemy from the enemies list to spawn
        int enemyNum = UnityEngine.Random.Range(0, enemies.Length);
        GameObject.Instantiate(enemies[enemyNum], spawnPos.normalized * 10, Quaternion.identity, transform);
        timer = 7;
    }


    void Update()
    {
        //spawna enemy
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SpawnEnemy();      

        }

    }
    public void DestroyEnemy()
    {
 
        Destroy(gameObject);
    }

}
