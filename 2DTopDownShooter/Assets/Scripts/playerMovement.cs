using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	public float playerX;
	public float playerY;
	public float moveSpeed = 2.0f;

	// Use this for initialization
	void Start () {
		playerX = transform.position.x;
		playerY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0.5f || Input.GetAxis("Vertical") < -0.5f)
		{
			playerY = Input.GetAxis("Vertical") * moveSpeed;
			transform.Translate(new Vector3(0.0f, playerY, 0.0f));
		}

		if(Input.GetAxis("Horizontal") > 0.5f || Input.GetAxis("Horizontal") < -0.5f)
		{
			playerX = Input.GetAxis("Horizontal") * moveSpeed;
			transform.Translate(new Vector3(playerX, 0.0f, 0.0f));
		}
	}
}
