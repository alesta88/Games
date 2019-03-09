using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    private AbsPl absPl;
    private DamagePL damagePL;

    public static float movementSpeed = 10f;
    float movement = 0f;
    

    public static bool IsPlaying = false;/// 


    Rigidbody2D rb;
    public static float velcc;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IsPlaying = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Platform db = collision.gameObject.GetComponent<Platform>();
            if (db == null) return;
            velcc = rb.velocity.y;
            db.SetJump();
    }
   
    private void FixedUpdate()
    {
        if (IsPlaying == true)
        {
            movement = Input.GetAxis("Horizontal") * movementSpeed;
            Vector2 velocity = rb.velocity;
            velocity.x = movement;
            rb.velocity = velocity;
        }
    }

}
