using ULTRAKILL.Enemy;
using UnityEngine;

public class PlayerTracker : MonoSingleton<PlayerTracker>, ITarget
{
	public PlayerType playerType;

	private bool initialized;

	private NewMovement nmov;

	private CameraController cc;

	public GameObject platformerPlayerPrefab;

	[HideInInspector]
	public GameObject currentPlatformerPlayerPrefab;

	[HideInInspector]
	public PlatformerMovement pmov;

	private Transform player;

	private Transform target;

	private Rigidbody playerRb;

	[HideInInspector]
	public bool levelStarted;

	private bool startAsPlatformer;

	public PlatformerCameraType cameraType;

	public GameObject[] platformerFailSafes;

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	private void Start()
	{
	}

	public Transform GetPlayer()
	{
		return null;
	}

	public Transform GetTarget()
	{
		return null;
	}

	public Rigidbody GetRigidbody()
	{
		return null;
	}

	public Vector3 PredictPlayerPosition(float time, bool aimAtHead = false, bool ignoreCollision = false)
	{
		return default(Vector3);
	}

	public Vector3 GetPlayerVelocity(bool trueVelocity = false)
	{
		return default(Vector3);
	}

	public bool GetOnGround()
	{
		return false;
	}

	public void ChangeToPlatformer()
	{
	}

	public void ChangeToPlatformer(bool ignorePreviousRotation = false)
	{
	}

	public void ChangeToFPS()
	{
	}

	private void Initialize()
	{
	}

	private void ChangeTargetParent(Transform toMove, Transform newParent, Vector3 offset = default(Vector3))
	{
	}

	public void CheckPlayerType()
	{
	}

	public void LevelStart()
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
