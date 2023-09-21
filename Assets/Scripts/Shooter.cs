using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    float timer;
    float shootingRate = 0.8f; //How often we can fire
    public Transform shootPoint; //the location that we want to spawn our shots
    public GameObject shootingPrefab;

    void Update()
    {
        Vector2 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        transform.up = direction;



        if (Input.GetMouseButton(0) && timer > shootingRate)
        {
            //Reset our timer
            timer = 0;
            var newBullet = Instantiate(shootingPrefab, shootPoint.position, transform.rotation);

        }
        timer += Time.deltaTime; 

    }

}
