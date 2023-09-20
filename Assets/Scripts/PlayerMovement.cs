using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    Vector2 position;
    private Rigidbody2D rb2d;
    Animator animator;

    void Start()
    {
        position = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        float moveDirectionX = Input.GetAxis("Horizontal");
        float moveDirectionY = Input.GetAxis("Vertical");

        Vector2 velocity = new Vector2(moveDirectionX * speed, moveDirectionY * speed);
        rb2d.velocity = velocity;

        animator.SetFloat("x", Input.GetAxis("Horizontal"));
        animator.SetFloat("y", Input.GetAxis("Vertical"));      
    }

}
