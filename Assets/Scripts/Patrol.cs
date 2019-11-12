using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	/// <summary>
	/// Patrol takes a GameObject and makes such object to patrol specified locations at the given speed
	/// </summary>
	public float moveSpeed; //Patrol speed

	[Header("Agent's patrol areas")]
	public List<Transform> patrolLocations; //List of all the Transform locations the gameObject will patrol

	[Space]
	[Header("Agent")]
	public GameObject patrollingGameObject; //Unity GameObject that patrols
	private int nextPatrolLocation; //Keeps track of the patrol location

	// Update is called once per frame
	private void Update()
	{
		PatrolArea();
	}

	//Moves the patrollingGameObject towards patrol location, when reach destination switch to next patrol position in the list
	private void PatrolArea()
	{
		patrollingGameObject.transform.position = Vector2.MoveTowards(
			patrollingGameObject.transform.position,
			patrolLocations[nextPatrolLocation].position, moveSpeed * Time.deltaTime
		);

		if (Vector2.Distance(
			    patrollingGameObject.transform.position, patrolLocations[nextPatrolLocation].position
		    ) <= 2)
		{
			nextPatrolLocation =
				(nextPatrolLocation + 1)
				% patrolLocations.Count; //Prevents IndexOutofBound by looping back through list
		}
	}
}