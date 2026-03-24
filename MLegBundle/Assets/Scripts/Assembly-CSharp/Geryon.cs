using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Geryon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawnBeamCoroutine_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Geryon _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSpawnBeamCoroutine_003Ed__85(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private bool active;

	private Animator anim;

	private Rigidbody rb;

	private EnemyIdentifier eid;

	private AudioSource aud;

	private GoreZone gz;

	private BossHealthBar bhb;

	private int difficulty;

	[SerializeField]
	private Transform rotateAround;

	[SerializeField]
	private float minimumAroundDistance;

	[SerializeField]
	private float maximumAroundDistance;

	private float rotateAroundDistance;

	private int moveDirection;

	private float moveSpeed;

	private bool inAction;

	private float cooldown;

	private bool trackY;

	private bool slowRotation;

	private Transform projectileParent;

	[SerializeField]
	private Transform leftHandShootPoint;

	[SerializeField]
	private Transform rightHandShootPoint;

	[SerializeField]
	private Transform bowShootPoint;

	[SerializeField]
	private GameObject bowChargeParticle;

	[SerializeField]
	private GameObject bowUpShootParticle;

	[SerializeField]
	private GameObject bowForwardShootParticle;

	[SerializeField]
	private GameObject bowUpBeam;

	[SerializeField]
	private GameObject bowForwardBeam;

	private int beamsAmount;

	private Coroutine beamRoutine;

	[SerializeField]
	private PhysicalShockwave clapShockwave;

	[SerializeField]
	private GameObject clapEffect;

	[SerializeField]
	private GameObject clapChargeParticle;

	private Vector3 clapChargeDefaultPosition;

	private bool clapChargeFollowing;

	[SerializeField]
	private Projectile palmProjectile;

	[SerializeField]
	private GameObject[] palmProjectileChargeParticles;

	private float projectileRotation;

	private int projectileRotationDirection;

	[SerializeField]
	private GameObject playerBlockerShield;

	[SerializeField]
	private GameObject playerPushBacker;

	[SerializeField]
	private GameObject playerProximityExplosion;

	private float playerPushBackerCooldown;

	[SerializeField]
	private GameObject dustParticle;

	private float currentHeat;

	private float maximumHeat;

	private float stunTime;

	private float maximumStunTime;

	private bool stunned;

	[SerializeField]
	private GameObject weakPointHitbox;

	[SerializeField]
	private GameObject fakeBloodSplatter;

	private float flashTimer;

	private float currentBarValue;

	private float originalHealth;

	private bool secondPhase;

	private bool cancelledAction;

	private TimeSince sinceCancelledAction;

	private List<GeryonAttack> previousAttacks;

	[SerializeField]
	private AudioClip bowUpSound;

	[SerializeField]
	private AudioClip bowForwardSound;

	[SerializeField]
	private AudioClip waveClapSound;

	[SerializeField]
	private AudioClip palmProjectilesSound;

	[SerializeField]
	private AudioClip bigHurtSound;

	[SerializeField]
	private AudioClip recoverySound;

	[SerializeField]
	private AudioClip deathSound;

	[Header("Body Part References")]
	public Collider tailBase;

	public Collider tailMid;

	public Collider wingRight;

	public Collider wingLeft;

	private GameObject currentEnrageEffect;

	public UltrakillEvent onPhaseChange;

	private void Start()
	{
	}

	private void UpdateDifficulty()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateCooldowns()
	{
	}

	private void PlayerBlocker()
	{
	}

	private void UpdateBossBar()
	{
	}

	private void MoveUpdate()
	{
	}

	private void PickAttack()
	{
	}

	private void BowUp()
	{
	}

	private void BowForward()
	{
	}

	private void WaveClap()
	{
	}

	private void PalmProjectiles()
	{
	}

	private void BowUpShoot()
	{
	}

	private void BowUpSpawnBeams()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnBeamCoroutine_003Ed__85))]
	private IEnumerator SpawnBeamCoroutine()
	{
		return null;
	}

	private void BowForwardShoot(int shotNumber)
	{
	}

	private void WaveClapShoot()
	{
	}

	private void PalmProjectileCharge()
	{
	}

	private void PalmProjectileShootBoth()
	{
	}

	private void PalmProjectileShoot(int hand)
	{
	}

	private void PalmProjectileShoot(int hand, float degrees, float speedMultiplier = 1f, float rotationSpeed = 0f)
	{
	}

	private void BowCharge()
	{
	}

	private void WaveClapCharge()
	{
	}

	private void WaveClapChargeFreeze()
	{
	}

	private void DustHands()
	{
	}

	private void Stun()
	{
	}

	private void HeadHort()
	{
	}

	private void HeadOpen()
	{
	}

	private void Unstun()
	{
	}

	private void UnstunClose()
	{
	}

	private void SkipRecovery()
	{
	}

	private void EndAction()
	{
	}

	private void StopAction()
	{
	}

	private void StopCharges()
	{
	}

	private void RandomizeDirection()
	{
	}

	private void PlaySound(AudioClip clip, float pitch = 1f)
	{
	}

	public void Death()
	{
	}

	private bool IsInMaxHeat()
	{
		return false;
	}
}
