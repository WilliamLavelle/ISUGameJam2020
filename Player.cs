using System.Collections;
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
   public Camera cam;
   private Vector2 mousePos;


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

      mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
   }

   void FixedUpdate()
   {
   	rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

      Vector2 lookDir = mousePos - rb.position;
      float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
   	rb.rotation = angle;
   }
}
