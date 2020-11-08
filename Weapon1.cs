using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
   public GameObject bulletPrefab;
   public Transform firePoint;
   public float force = 20f;

   private int gun = 1;
   

   void Update()
   {
   	if(Input.GetButtonDown("Fire1"))
   	{
         if(gun == 1)
         {
            Shoot();
         } else if(gun == 2)
         {
            Shoot2();
         } else
         {
            Shoot3();
         }
   	}
   }

   void Shoot()
   {
      GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
      rb.AddForce(firePoint.up * force, ForceMode2D.Impulse);
   }

   void Shoot2()
   {
      // TRASH
      // GameObject bullet1 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      // GameObject bullet2 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      // GameObject bullet3 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      // GameObject bullet4 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      // GameObject bullet5 = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

      // Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>();
      // Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>();
      // Rigidbody2D rb3 = bullet3.GetComponent<Rigidbody2D>();
      // Rigidbody2D rb4 = bullet4.GetComponent<Rigidbody2D>();
      // Rigidbody2D rb5 = bullet5.GetComponent<Rigidbody2D>();

      // force = 10;
      // rb1.AddForce(firePoint.up + new Vector3(0,0,-25) * force, ForceMode2D.Impulse);
      // rb2.AddForce(firePoint.up + new Vector3(0,0,-10) * force, ForceMode2D.Impulse);
      // rb3.AddForce(firePoint.up + new Vector3(0,0,0) * force, ForceMode2D.Impulse);
      // rb4.AddForce(firePoint.up + new Vector3(0,0,10) * force, ForceMode2D.Impulse);
      // rb5.AddForce(firePoint.up + new Vector3(0,0,25) * force, ForceMode2D.Impulse);
   }

   void Shoot3()
   {

   }
}
