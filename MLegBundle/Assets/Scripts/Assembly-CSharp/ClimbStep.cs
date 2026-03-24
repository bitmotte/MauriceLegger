using UnityEngine;

public class ClimbStep : MonoBehaviour
{
	private InputManager inman;

	private Rigidbody rb;

	private int layerMask;

	private NewMovement newMovement;

	private float step;

	private float allowedAngle;

	private float allowedSpeed;

	private float allowedInput;

	private float cooldown;

	private float cooldownMax;

	private float deltaVertical;

	private float deltaHorizontal;

	private Vector3 gizmoPosition1;

	private Vector3 gizmoPosition2;

	private Vector3 movementDirection;

	public Matrix4x4? portalTravelMatrix;

	private Transform targetTransform;

	private Rigidbody targetRb;

	public void SetTarget(Transform targetTransform, Rigidbody targetRb)
	{
	}

	public bool TryClimb(Vector3 position, RaycastHit hit, ref Matrix4x4 portalTravelMatrix, bool allowCollisionResolution = true)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	private bool HandleCollision(Vector3 position, Vector3 up, Vector3 verticalVelocity, float verticalSpeed, Vector3 normal, Vector3 relativeVelocity, Vector3 movementDirection, bool allowCollisionResolution = true)
	{
		return false;
	}
}
