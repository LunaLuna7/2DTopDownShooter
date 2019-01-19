using UnityEngine;

public class FollowTarget : MonoBehaviour
{
	public GameObject target;

	private Vector3 m_Offset;

	private void Start()
	{
		m_Offset = transform.position - target.transform.position;
	}

	private void LateUpdate()
	{
		transform.position = target.transform.position + m_Offset;
	}
}