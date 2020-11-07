using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
   public GameObject bulletPrefab;
   private Transform playerPos;

   void Start()
   {
   	playerPos = GetComponent<Transform>();
   }

   void Update()
   {
   	if(Input.GetButtonDown("Fire1"))
   	{
   		Shoot();
   	}
   }

   void Shoot()
   {
      Instantiate(bulletPrefab, playerPos.position, Quaternion.identity);
   }
}
