using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private float moveInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       moveInput = Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

       if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
       }
    }

    void OnCollisionStay2D(Collision2D collision) 
    {
        Debug.Log("Menyentuh Objek" + collision.gameObject.name);

        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
