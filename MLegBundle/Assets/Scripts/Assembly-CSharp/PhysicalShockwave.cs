using System.Collections.Generic;
using ULTRAKILL.Portal;
using UnityEngine;

[DefaultExecutionOrder(1000)]
public class PhysicalShockwave : MonoBehaviour
{
	private struct OriginDepthPair
	{
		public readonly Transform origin;

		public readonly int depth;

		public readonly PortalHandleSequence portalSequence;

		public OriginDepthPair(Transform origin, int depth, PortalHandleSequence portalSequence = default(PortalHandleSequence))
		{
			this.origin = null;
			this.depth = 0;
			this.portalSequence = default(PortalHandleSequence);
		}
	}

	private const int MaxReplicaCount = 12;

	public EnemyTarget target;

	public int damage;

	public float speed;

	public float maxSize;

	public float force;

	public bool hasHurtPlayer;

	public bool ignorePlayerDash;

	public bool enemy;

	public bool noDamageToEnemy;

	private List<Collider> hitColliders;

	public EnemyType enemyType;

	public GameObject soundEffect;

	[HideInInspector]
	public bool fading;

	private ScaleNFade[] faders;

	private GameObject[] portalReplicas;

	private HashSet<PortalHandle> replicaPortalHandles;

	private void Start()
	{
	}

	private void CreatePortalReplicas()
	{
	}

	private void Update()
	{
	}

	private void DestroyReplicas()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	public void HandleReplicaCollision(Collider col, PortalHandle portalHandle, Vector3 previousOriginPosition, Vector3 closestPoint)
	{
	}

	private bool SimpleCollisionCheck(Collider col)
	{
		return false;
	}

	private bool PrecisePortalCheck(PortalHandle portalHandle, Vector3 startPosition, Vector3 closestPoint)
	{
		return false;
	}

	private void CheckCollision(Collider col)
	{
	}

	private void GetDestroyed()
	{
	}
}
