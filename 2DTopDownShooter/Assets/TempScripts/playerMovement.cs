using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	[Header("Player Variables")]
	public float playerX = 0; //player position x
	public float playerY = 0; //player position y
	public float moveSpeed = 15.0f; //speed of the player
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//player moves up or down
		if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			playerY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
			transform.Translate(new Vector3(0.0f, playerY, 0.0f));
		}
		//player moves left or right
		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
		{
			playerX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
			transform.Translate(new Vector3(playerX, 0.0f, 0.0f));
		}
	}
}
