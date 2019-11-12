using UnityEngine;

public class ConstantHealSource : MonoBehaviour
{
	public int healAmount = 1;
	/// <summary>
	/// If true, the game object will not be destroyed after healing.
	/// </summary>
	public bool persistent;

	private void OnTriggerEnter2D(Collider2D other)
	{
		var otherHealth = other.GetComponent<HealthPool>();
		if (otherHealth == null) return;
		if (!otherHealth.CompareTag("Player")) return;

		otherHealth.Heal(healAmount);

		if (!persistent)
		{
			Destroy(gameObject);
		}
	}
}