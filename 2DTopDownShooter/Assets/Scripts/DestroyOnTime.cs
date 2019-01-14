using UnityEngine;

/// <summary>
/// Automatically destroys the game object after a certain interval.
/// Note that the timer only starts after the script is enabled.
/// The destruction is not cancellable.
/// </summary>
public class DestroyOnTime : MonoBehaviour
{
	public float time;

	void Start()
	{
		Destroy(gameObject, time);
	}
}