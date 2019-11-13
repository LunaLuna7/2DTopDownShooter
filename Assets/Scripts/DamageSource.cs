using UnityEngine;

public class DamageSource : MonoBehaviour
{
	public float damageAmount;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
			playerHealth.TakeDamage(damageAmount);
		}
	}
}