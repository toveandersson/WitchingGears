using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShoot : MonoBehaviour
{
    float timer;
    float shootingRate = 0.8f; //How often we can fire
    public Transform TestshootPoint; //the location that we want to spawn our shots
    public GameObject TestshootingPrefab;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        transform.up = direction;



        if (Input.GetMouseButton(0) && timer > shootingRate)
        {
            //Reset our timer
            timer = 0;

            Instantiate(TestshootingPrefab, TestshootPoint.position, transform.rotation);
            cameraMovement.Instance.ShakeCamera(5f, .1f);
        }
        timer += Time.deltaTime;

    }
}
