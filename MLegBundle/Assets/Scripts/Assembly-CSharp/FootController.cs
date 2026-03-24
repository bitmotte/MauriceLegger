using UnityEngine;
using UnityEngine.AI;

public class FootController : MonoBehaviour
{
	public Transform root;

	public Transform body;

	public LayerMask canSee;

	public Vector3 tiltAmounts;

	[SerializeField]
	private IKFootSolver[] footSolvers;

	public float maxMoveDistance;

	public float maxFootHeight;

	public float strideFrequency;

	private Vector3 rootUp;

	private Vector3 rootForward;

	private Vector3 rootRight;

	private Quaternion rootRotation;

	private float PosAdjustRatio;

	public float bodyBobSmoothness;

	private float RotAdjustRatio;

	public float rotateSpeed;

	private Vector3 initialBodyOffset;

	private Quaternion initialBodyRot;

	[Range(0f, 1f)]
	public float nextStepThreshold;

	private GroundCheck gc;

	private NavMeshAgent nma;

	private bool isWalking;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void BobBodyFromLegs()
	{
	}

	public void StartWalk(IKFootSolver startFoot)
	{
	}

	public void StartNextFootStep(IKFootSolver foot)
	{
	}

	private void AdjustBodyTransform()
	{
	}
}
