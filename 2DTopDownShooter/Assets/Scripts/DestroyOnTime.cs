using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
	public float time;

	void Start()
	{
		Destroy(gameObject, time);
	}
}