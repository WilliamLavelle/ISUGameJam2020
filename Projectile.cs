using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private Vector3 target;
	public float speed;
	public Rigidbody2D rb;
	//public GameObject enemy;

	void Start()
	{
		// rb.velocity = Camera.main.ScreenToWorldPoint(Input.mousePosition) * speed;
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void Update()
	{
		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
}
