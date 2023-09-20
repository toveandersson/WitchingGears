using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tsetEnemy : MonoBehaviour
{
    

    Rigidbody2D rb2D;
    Transform target;
    public float speed = 5;
    void Start()

    {
        target = GameObject.FindGameObjectWithTag("target").transform;
        rb2D = GetComponent<Rigidbody2D>();

  
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        rb2D.velocity = direction * speed;

    }
}
