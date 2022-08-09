using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement; 

    public float dashSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxisRaw gets a value in range -1...1 (always -1,0, or 1 for keyboard)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Essentially getting to current Vector to the new Vector (movement) that is being updated each frame
        // multiply by speed for how fast this transition occurs and Time.fixedDeltaTime for smoothness
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
