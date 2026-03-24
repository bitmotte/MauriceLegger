using Unity.Burst;
using UnityEngine;

public class Bloodsplatter : MonoBehaviour
{
	public BSType bloodSplatterType;

	[HideInInspector]
	public ParticleSystem part;

	private int i;

	private AudioSource aud;

	private int eidID;

	private SpriteRenderer sr;

	private MeshRenderer mr;

	private NewMovement nmov;

	public int hpAmount;

	private SphereCollider col;

	public bool hpOnParticleCollision;

	[HideInInspector]
	public bool beenPlayed;

	public bool halfChance;

	public bool ready;

	public GoreZone gz;

	public bool underwater;

	private MaterialPropertyBlock propertyBlock;

	private bool canCollide;

	public BloodsplatterManager bsm;

	[HideInInspector]
	public bool fromExplosion;

	private ComponentsDatabase cdatabase;

	[HideInInspector]
	public EnemyIdentifier eid
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Collide(Collider other)
	{
	}

	public void Repool()
	{
	}

	[BurstCompile]
	public void CreateBloodstain(in RaycastHit hit, BloodsplatterManager bsman)
	{
	}

	private void DisableCollider()
	{
	}

	public void GetReady()
	{
	}
}
