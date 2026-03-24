using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class MannequinString : MonoBehaviour
{
	public float width;

	public float lengthScale;

	public float wobbleStrength;

	public float wobbleSpeed;

	private LineRenderer lRend;

	private float randomOffset;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
