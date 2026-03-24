using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
	public virtual Vector3 VisionSourcePosition => default(Vector3);

	public virtual EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	public virtual bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}

	public virtual void OnGoLimp(bool fromExplosion)
	{
	}

	public virtual void OnFall()
	{
	}

	public virtual void OnLand()
	{
	}

	public virtual void OnDamage(ref DamageData data)
	{
	}

	public virtual void OnParry(ref DamageData data, bool isShotgun)
	{
	}

	public virtual void OnTargetTick()
	{
	}

	public virtual void OnTeleport(PortalTravelDetails details)
	{
	}

	public virtual void SetSortiePos(Vector3 pos)
	{
	}

	protected Vector3 ToPlanePos(Vector3 pos)
	{
		return default(Vector3);
	}

	protected float GetUpdateRate(NavMeshAgent nma = null, float min = 0.2f, float max = 0.5f, float distanceThreshold = 10f)
	{
		return 0f;
	}

	public static bool CheckTarget(TargetDataRef targetData, EnemyIdentifier eid)
	{
		return false;
	}

	protected bool ChasePortalTarget(NavMeshAgent nma, TargetData visionData, NavMeshPath path)
	{
		return false;
	}

	protected void NavigateInFrontOfPortal(NavMeshAgent nma, PortalHandle handle)
	{
	}

	protected void AcquirePortalVision(NavMeshAgent nma, AcquirePortalVisionState state)
	{
	}
}
