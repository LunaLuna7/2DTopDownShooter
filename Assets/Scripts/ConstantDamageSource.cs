using UnityEngine;

public class ConstantDamageSource : MonoBehaviour
{
	public int damageAmount = 1;
	public bool damagePlayer = true;
	public bool damageEnemy = true;
	/// <summary>
	/// If true, the game object will not be destroyed after dealing damage.
	/// </summary>
	public bool persistent;

	private void OnTriggerEnter2D(Collider2D other)
	{
		var otherHealth = other.GetComponent<HealthPool>();
		if (otherHealth == null) return;
		if (other.CompareTag("Player") && !damagePlayer) return;
		if (other.CompareTag("Enemy") && !damageEnemy) return;

		otherHealth.Damage(damageAmount);

		if (!persistent)
		{
			Destroy(gameObject);
		}
	}
}