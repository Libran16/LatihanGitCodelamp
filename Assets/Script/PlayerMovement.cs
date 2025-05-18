using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;
    private SpriteRenderer spriteRenderer;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        float move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        
        if (move > 0) spriteRenderer.flipX = false;
        else if (move < 0) spriteRenderer.flipX = true;

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }

        anim.SetBool("isWalking", move != 0);
        anim.SetBool("isJumping", !isGrounded);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.contacts[0].normal.y > 0.5f) {
            isGrounded = true;
        }
    }
}
