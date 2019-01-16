using UnityEditor;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
	public float speed = 5;
	public bool instant;

	private void Update()
	{
		Vector2 mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
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