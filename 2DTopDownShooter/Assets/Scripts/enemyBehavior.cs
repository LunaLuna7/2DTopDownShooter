using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour {
	public int startingHealth = 1; //the max health of enemy gameObject
	[HideInInspector]public int health; //current health of the enemy gameObject

	// Use this for initialization
	void Start () {
		//initalize the current health to starting health
		health = startingHealth; 
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Destroy(gameObject);
	}
}
