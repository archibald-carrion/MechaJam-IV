using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // handle the inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // handle movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
