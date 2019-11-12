using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float health;

	public void Damage(float amount)
	{
		health -= amount;

		if (health <= 0)
		{
			gameObject.SetActive(false);
		}
	}
}