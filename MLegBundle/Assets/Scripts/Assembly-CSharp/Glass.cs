using System.Collections.Generic;
using System.Threading;
using ULTRAKILL.Enemy;
using UnityEngine;

public class Glass : MonoBehaviour, ITarget
{
	public bool broken;

	public bool wall;

	private Transform[] glasses;

	public GameObject shatterParticle;

	private int kills;

	private Collider[] cols;

	private List<GameObject> enemies;

	public UltrakillEvent onShatter;

	private CancellationTokenSource becomeObsticleTokenSource;

	private Vector3 cachedPos;

	private Quaternion cachedRot;

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Shatter()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void BecomeObstacle()
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
