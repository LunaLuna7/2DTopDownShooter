using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
	private Image m_HealthBar;
	public HealthPool playerHealth;

	private void Start()
	{
		m_HealthBar = GetComponent<Image>();
	}

	public void OnPlayerHealthChange()
	{
		m_HealthBar.fillAmount = (float) playerHealth.health / playerHealth.maxHealth;
	}
}