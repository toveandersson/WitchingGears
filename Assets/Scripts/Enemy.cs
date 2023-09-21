using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public float spawnTimer = 0;
    public float spawnTimerTimer = 20;
    public GameObject gumma;
    public GameObject bullet;
    private Vector2 spawnPos;
    public int spawnDistance = 3;
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
        GameObject.Instantiate(enemies[enemyNum], spawnPos.normalized *spawnDistance, Quaternion.identity, transform);
        spawnDistance = 10;
        if (spawnTimerTimer < 0)
        {
            spawnTimer = 1;
        }
        else if (spawnTimerTimer > 0) 
        {
            spawnTimer = 3;
        }
    }

    void Update()
    {
        //spawna enemy
        spawnTimer -= Time.deltaTime;
        spawnTimerTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            SpawnEnemy();      

        }

    }
    public void DestroyEnemy()
    {
 
        Destroy(gameObject);
    }

}
