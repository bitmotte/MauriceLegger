using UnityEngine;

public class EndlessScrollingPiece : MonoBehaviour
{
	private Rigidbody rb;

	public Vector3 velocity;

	public float maxDistance;

	public bool moveContinuously;

	public bool inLocalSpace;

	[HideInInspector]
	public float moveAmountLeft;

	[HideInInspector]
	public Vector3 stoppingSpot;

	private Vector3 originalPosition;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Move()
	{
	}

	private void Move(Vector3 amount)
	{
	}

	public void AddMovement(float units)
	{
	}

	public void ResetPosition()
	{
	}
}
