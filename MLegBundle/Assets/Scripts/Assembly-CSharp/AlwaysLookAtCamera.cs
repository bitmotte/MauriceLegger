using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class AlwaysLookAtCamera : MonoBehaviour
{
	public UpdateType updateType;

	public TargetData? overrideTargetData;

	public Transform overrideTarget;

	public EnemyTarget target;

	[Space]
	[Tooltip("If the target is player (null), use the camera instead of the player head position. Helpful in third-person mode.")]
	public bool preferCameraOverHead;

	[Tooltip("Copies camera's rotation instead of looking at the camera, this will mean the object always appears flat like a sprite.")]
	public bool faceScreenInsteadOfCamera;

	[Tooltip("Always face camera's origin point instead of tracking the camera when it's shaking.")]
	public bool ignoreScreenShake;

	public bool dontRotateIfBlind;

	[Tooltip("Only track the target if there is a direct line of sight, otherwise stay still")]
	public bool onlyTrackWithLineOfSight;

	public float speed;

	public bool easeIn;

	public float maxAngle;

	[Space]
	public bool useXAxis;

	public bool useYAxis;

	public bool useZAxis;

	[Space]
	public Vector3 rotationOffset;

	[Space]
	public float maxXAxisFromParent;

	public float maxYAxisFromParent;

	public float maxZAxisFromParent;

	public bool useLocalMode;

	public bool dontUseFaceCamera;

	[Header("Enemy")]
	public EnemyIdentifier eid;

	private int difficulty;

	public bool difficultyVariance;

	private float difficultySpeedMultiplier;

	private ParticleSystemForceUpdater[] particleSystemForceUpdaters;

	private PortalManagerV2 _subscribedPortalManager;

	public void FaceCamera(Camera cam)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void EnsureTargetExists()
	{
	}

	private void SlowUpdate()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void Tick()
	{
	}

	public void ChangeOverrideTarget(EnemyTarget target)
	{
	}

	public void ChangeOverrideTarget(Transform target)
	{
	}

	public void SnapToTarget()
	{
	}

	public void ChangeSpeed(float newSpeed)
	{
	}

	public void ChangeDifficulty(int newDiff)
	{
	}

	public void UpdateDifficulty()
	{
	}
}
