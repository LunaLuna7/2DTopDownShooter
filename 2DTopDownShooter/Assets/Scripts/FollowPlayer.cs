using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;

	private Vector3 m_Offset;

	private void Start()
	{
		m_Offset = transform.position - player.transform.position;
	}

	private void LateUpdate()
	{
		transform.position = player.transform.position + m_Offset;
	}
}