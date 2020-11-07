using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public float speed;
   private Transform playerPos;
   private Player player;
   public GameObject deathExplosion;
   public GameObject damageExp;

   void Start()
   {
    player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
   	playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
   }

   void Update()
   {
   	transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

      Vector3 target = playerPos.position;
      target.x = target.x - transform.position.x;
      target.y = target.y - transform.position.y;
      float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(new Vector3(0,0, angle - 90));
      
   }

   void OnTriggerEnter2D(Collider2D other)
   {
      if(other.CompareTag("Player"))
      {
         player.health--;
         Destroy(gameObject);
         Instantiate(damageExp, transform.position, Quaternion.identity);

      }

      if(other.CompareTag("Projectile"))
      {
         Destroy(gameObject);
         Destroy(other.gameObject);
         Instantiate(deathExplosion, transform.position, Quaternion.identity);

      }
   }
}
