using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Manages health for both players and enemies.
/// </summary>
public class Health : MonoBehaviour
{
	public int maxHealth;
	public int health { get; private set; }
	
	public UnityEvent afterHealthChange;
	public UnityEvent onDeath;


	private void Start()
	{
		health = maxHealth;
	}

	public void Damage(int amount)
	{
		health = Mathf.Clamp(health - amount, 0, maxHealth);

		afterHealthChange.Invoke();

		if (health <= 0)
		{
			onDeath.Invoke();
		}
	}

	public void Heal(int amount)
	{
		health = Mathf.Clamp(health + amount, 0, maxHealth);
		
		afterHealthChange.Invoke();
	}

	// A common action is to destroy the object on death. Add this listener to the `onDeath` event to achieve that effect.
	public void DestroyOnDeath()
	{
		Destroy(gameObject);
	}
}