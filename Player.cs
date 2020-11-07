﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

   public float speed;
   public int health = 4;

   public Text healthDisp;
   private Rigidbody2D rb;
   private Vector2 moveVelocity;

   void Start()
   {
   	rb = GetComponent<Rigidbody2D>();
   }

   void Update()
   {
      if(health <= 0)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }

      healthDisp.text = "Health: " + health;

   	Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
   	moveVelocity = moveInput.normalized * speed;
   }

   void FixedUpdate()
   {
   	rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
   	
   }
}