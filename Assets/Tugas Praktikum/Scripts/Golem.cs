using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public int maxJumpCount = 2;

    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded;
    private int jumpCount;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);

        if (move > 0) spriteRenderer.flipX = false;
        else if (move < 0) spriteRenderer.flipX = true;
        
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumpCount) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
            isGrounded = false;
        }

        anim.SetBool("isWalking", move != 0);
        anim.SetBool("isJumping", !isGrounded);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Ground") && collision.contacts[0].normal.y > 0.5f) {
            isGrounded = true;
            jumpCount = 0;
        }
        else{
            Debug.Log("Platform yang diinjak tidak memiliki tag 'Ground '" + collision.collider.name);
        }
    }
}
