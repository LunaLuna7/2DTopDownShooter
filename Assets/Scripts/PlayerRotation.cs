using UnityEditor;
using UnityEngine;

/// <summary>
/// Manages player rotation based on mouse position.
/// </summary>
/// <remarks>
///	Requires the original player image to face right.
/// </remarks>
public class PlayerRotation : MonoBehaviour
{
	public float speed = 5;
	public bool instant;

	private Camera m_MainCamera;

	private void Start()
	{
		m_MainCamera = Camera.main;
	}

	private void Update()
	{
		Vector2 mouseDirection = m_MainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float mouseAngle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;
		Quaternion desiredRotation = Quaternion.AngleAxis(mouseAngle, Vector3.forward);

		if (instant)
		{
			transform.rotation = desiredRotation;
		}
		else
		{
			transform.rotation = Quaternion.RotateTowards(
				transform.rotation,
				desiredRotation,
				speed * Time.deltaTime * Mathf.Rad2Deg
			);
		}
	}
}

/// <summary>
/// A custom editor for <c>PlayerRotation</c> that disables the (meaningless) <c>speed</c> when <c>instant</c> is set to true. 
/// </summary>
[CustomEditor(typeof(PlayerRotation))]
public class PlayerRotationEditor : Editor
{
	public override void OnInspectorGUI()
	{
		var script = target as PlayerRotation;
		Debug.Assert(script != null);

		if (script.instant) GUI.enabled = false;
		script.speed = EditorGUILayout.FloatField("Speed", script.speed);
		GUI.enabled = true;

		script.instant = EditorGUILayout.Toggle("Instant", script.instant);
	}
}