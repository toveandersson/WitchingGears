using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityRandom = UnityEngine.Random;


public class testEnemSpan : MonoBehaviour
{
    public GameObject objectToSpawn; // The object you want to spawn.
    public float spawnInterval = 2.0f; // Time interval between spawns.

    private float timer = 0.0f;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            SpawnObjectsOnAllSides();
            timer = spawnInterval;
        }
    }

    void SpawnObjectsOnAllSides()
    {
        // Get the screen boundaries in world coordinates.
        float screenHeight = mainCamera.orthographicSize * 2.0f;
        float screenWidth = screenHeight * mainCamera.aspect;

        // Calculate positions for all sides.
        Vector3 topPosition = new Vector3(0, screenHeight / 2, 0);
        Vector3 bottomPosition = new Vector3(0, -screenHeight / 2, 0);
        Vector3 leftPosition = new Vector3(-screenWidth / 2, 0, 0);
        Vector3 rightPosition = new Vector3(screenWidth / 2, 0, 0);

        // Instantiate objects at calculated positions.
        Instantiate(objectToSpawn, topPosition, Quaternion.identity);
        Instantiate(objectToSpawn, bottomPosition, Quaternion.identity);
        Instantiate(objectToSpawn, leftPosition, Quaternion.identity);
        Instantiate(objectToSpawn, rightPosition, Quaternion.identity);
    }
}


