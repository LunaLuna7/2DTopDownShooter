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
		if (Input.GetAxis("Vertical") < 0.0f)
		{
			playerY = Input.GetAxis("Vertical") * moveSpeed;
		}
		else if (Input.GetAxis("Vertical") > 0.0f)
		{
			playerY = Input.GetAxis("Vertical") * moveSpeed;
		}
		else if (Input.GetAxis("Horizontal") < 0.0f)
		{
			playerX = Input.GetAxis("Horizontal") * moveSpeed;
		}
		else if (Input.GetAxis("Horizontal") > 0.0f)
		{
			playerX = Input.GetAxis("Horizontal") * moveSpeed;
		}

		transform.position = new Vector3(playerX, playerY, transform.position.z);
	}
}
