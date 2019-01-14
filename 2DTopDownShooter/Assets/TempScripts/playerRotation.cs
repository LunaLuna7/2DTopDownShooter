using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour {
	[Header("Rotation Variables")]
	public float mouseAngle = 0; //the angle for the player to face (in Degrees)
	public float rotationSpeed = 5.0f; //the speed to rotate the character

	private Vector2 mouseDirection; //where the mouse is in relation to the player
	private Quaternion rotator; //how much we need to rotate

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*Handles character rotation*/
		//Must make place face right to follow mouse movement
		mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		mouseAngle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg; //conversion from radians to degrees
		rotator = Quaternion.AngleAxis(mouseAngle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, 
			rotator, rotationSpeed * Time.deltaTime);
	}
}
