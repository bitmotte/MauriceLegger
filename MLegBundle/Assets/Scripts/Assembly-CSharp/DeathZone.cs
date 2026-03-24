using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
	private NewMovement pm;

	public GameObject sawSound;

	public string deathType;

	public bool dontExplode;

	public bool splatter;

	public bool enemiesCanDodge;

	public bool aliveOnly;

	public bool deleteLimbs;

	public bool requireMatchingUpDirection;

	public AffectedSubjects affected;

	private bool playerAffected;

	private bool enemyAffected;

	public bool checkForPlayerOutsideTrigger;

	[Space(10f)]
	public bool notInstakill;

	public Vector3 respawnTarget;

	public bool dontChangeRespawnTarget;

	public int damage;

	public int styleAmount;

	private Transform player;

	public EnemyType[] unaffectedEnemyTypes;

	private List<EnemyIdentifier> alreadyHitEnemies;

	public UltrakillEvent onHitPlayer;

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void GotHit(Collider other)
	{
	}
}
