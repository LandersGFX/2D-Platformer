using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody2d;
    float xmovement;
    
    public float jumpForce = 20f;
    bool isGrounded;
    public Transform GroundHitbox;
    public LayerMask groundLayers;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        xmovement = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(xmovement * speed, rigidbody2d.velocity.y);

        rigidbody2d.velocity = movement;
    }
    void Jump()
    {
        Vector2 movement = new Vector2(rigidbody2d.velocity.x, jumpForce);
        rigidbody2d.velocity = movement;
    }
    public bool IsGrounded()
    {
        Collider2D groundCheck = Physics2D.OverlapCircle(GroundHitbox.position, 0.5f, groundLayers);
        if (groundCheck.gameObject != null){
            return true;
        }
        return false;
    }
}
