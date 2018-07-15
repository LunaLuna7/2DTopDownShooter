using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	public float playerX = 0;
	public float playerY = 0;
	public float moveSpeed = 0.75f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			playerY = Input.GetAxisRaw("Vertical") * moveSpeed;
			transform.Translate(new Vector3(0.0f, playerY, 0.0f));
		}

		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
		{
			playerX = Input.GetAxisRaw("Horizontal") * moveSpeed;
			transform.Translate(new Vector3(playerX, 0.0f, 0.0f));
		}
	}
}
