using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour {
	[Header("Shooting Number Variables")]
	public float shootingDistance = 300.0f; //how far the bullet should travel (detect enemy)
	public Transform firingPoint; //Where the bullet will travel/check from (realistic gun)
	private Vector2 mousePosition; //position of mouse
	private Vector2 firingOrigin; //the (x,y) cooridnates of the firingpoint gameObject
	private RaycastHit2D hit; //the line the bullet will follow

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			fire();
		}
	}

	void fire()
	{
		/*Handles player shooting bullets that checks within a line (hitscan)*/
		firingOrigin = new Vector2(firingPoint.position.x, firingPoint.position.y);
		mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
			Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		hit = Physics2D.Raycast(firingOrigin, mousePosition-firingOrigin, shootingDistance);

		//Make sure that the firingOrigin is far from the player gameObject 
		//to ensure that the raycast hits the enemies and not collide with the player itself
		//and tag all enemies with the same tag to compare
		if (hit && hit.collider.CompareTag("Enemy"))
		{
			Debug.DrawLine(firingOrigin, mousePosition, Color.green, 0.5f);
		}
		else
		{
			Debug.DrawLine(firingOrigin, mousePosition, Color.red, 0.5f);
		}
	}
}
