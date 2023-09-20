using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    Animator animator;

    Rigidbody2D rb2D;
    Transform target;
    public float speed = 1;
    void Start()

    {
        target = GameObject.FindGameObjectWithTag("target").transform;
        rb2D = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        rb2D.velocity = direction * speed;

        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }





}
