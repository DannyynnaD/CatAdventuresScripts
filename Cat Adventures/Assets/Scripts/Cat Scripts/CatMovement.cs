﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CatMovement : MonoBehaviour
{
    //Variables for horizontal movement
    public float speed;
    private Rigidbody2D rb2d;
    private Vector2 moveVelocity;

    //Called once when game starts
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    //Called every frame
    void Update()
    {
        //Horizontal movement
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity = moveInput * speed;
    }
    //Manages physics related objects in the game (including movement cause of rb2d)
    void FixedUpdate()
    { 
        rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
    }
}
