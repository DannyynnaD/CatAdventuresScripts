﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CattieJump : MonoBehaviour
{
    private Rigidbody2D rb2d;
    //Ground detection variables
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    //Jumping variables
    public float jumpForce;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb2d.AddForce (Vector2.up * jumpForce);
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
}
