using ULTRAKILL.Enemy;
using UnityEngine;
using UnityEngine.AI;

public class Puppet : EnemyScript
{
	private NavMeshAgent nma;

	[SerializeField]
	private SwingCheck2 sc;

	private Animator anim;

	private EnemyIdentifier eid;

	private Enemy mach;

	private Rigidbody rb;

	private VisionQuery nearestQuery;

	private TargetData nearestData;

	private TargetHandle nearestHandle;

	private Vector3 targetPos;

	private bool inAction;

	private bool moving;

	private Vision vision => null;

	private void Start()
	{
	}

	private void SlowUpdate()
	{
	}

	private void Update()
	{
	}

	private void UpdateTargetVision()
	{
	}

	private void Swing()
	{
	}

	private void DamageStart()
	{
	}

	private void DamageStop()
	{
	}

	private void StopAction()
	{
	}
}
