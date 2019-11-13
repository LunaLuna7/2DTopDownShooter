using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Manages health for both players and enemies.
/// </summary>
/// <remarks>
/// `health` is a read-only attribute to get the current health in the health pool.
/// `Damage` and `Heal` do what you think they do.
/// The class currently contains 2 events, `afterHealthChange` and `onDeath`.
/// `afterHealthChange` gets invoked at the end of a `Damage`/`Heal` call. It's useful for things like updating the health HUD.
///	`onDeath` gets invoked when `health` reaches 0. You can pair it with `DestroyOnDeath` to destroy the game object, or implement your custom death mechanic.
/// </remarks>
public class HealthPool : MonoBehaviour
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
		Debug.Assert(amount >= 0);

		health = Mathf.Clamp(health - amount, 0, maxHealth);

		afterHealthChange.Invoke();

		if (health <= 0)
		{
			onDeath.Invoke();
		}
	}

	public void Heal(int amount)
	{
		Debug.Assert(amount >= 0);

		health = Mathf.Clamp(health + amount, 0, maxHealth);

		afterHealthChange.Invoke();
	}

	// A common action is to destroy the object on death. Add this listener to the `onDeath` event to achieve that effect.
	public void DestroyOnDeath()
	{
		Destroy(gameObject);
	}
}