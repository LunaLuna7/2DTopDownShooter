using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Manages health for both players and enemies.
/// </summary>
public class Health : MonoBehaviour
{
	public int maxHealth;
	private int m_Health;

	public UnityEvent afterHealthChange;
	
	public int health
	{
		get { return m_Health; }
		set
		{
			m_Health = Mathf.Clamp(value, 0, maxHealth);

			afterHealthChange.Invoke();

			if (m_Health <= 0)
			{
				Die();
			}
		}
	}

	void Start()
	{
		health = maxHealth;
	}

	void Die()
	{
		Destroy(gameObject);
	}
}