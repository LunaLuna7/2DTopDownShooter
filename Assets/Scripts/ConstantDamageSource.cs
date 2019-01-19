using UnityEngine;

public class ConstantDamageSource : MonoBehaviour
{
	public int damageAmount = 1;
	/// <summary>
	/// If true, the game object will not be destroyed after dealing damage.
	/// </summary>
	public bool persistent;

	private void OnTriggerEnter2D(Collider2D other)
	{
		var otherHealth = other.GetComponent<HealthPool>();
		if (otherHealth == null) return;
		
		otherHealth.Damage(damageAmount);

		if (!persistent)
		{
			Destroy(gameObject);
		}
	}
}