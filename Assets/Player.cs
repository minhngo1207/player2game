using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public string axisName;
    
    private float movement;
    
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw(axisName);
        
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
