using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMovement : MonoBehaviour
{
    public float speed = 3f;
    Vector2 position;
    private Rigidbody2D rb2d;



    void Start()
    {
        position = transform.position;
        rb2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = position;
    }
}
