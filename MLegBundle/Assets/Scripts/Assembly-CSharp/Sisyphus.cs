using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NewBlood.IK;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Solver3D))]
public class Sisyphus : EnemyScript
{
	private enum AttackType
	{
		OverheadSlam = 0,
		HorizontalSwing = 1,
		Stab = 2,
		AirStab = 3
	}

	[CompilerGenerated]
	private sealed class _003CAirStab_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

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
		public _003CAirStab_003Ed__111(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAirStabAttack_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

		public float time;

		private Vector3 _003Cstart_003E5__2;

		private float _003Ct_003E5__3;

		private Vector3 _003CattackTarget_003E5__4;

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
		public _003CAirStabAttack_003Ed__112(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CHorizontalSwingAttack_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

		public float time;

		private float _003Ct_003E5__2;

		private Vector3 _003CactualTarget_003E5__3;

		private float _003CprogressEnd_003E5__4;

		private float _003CyPos_003E5__5;

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
		public _003CHorizontalSwingAttack_003Ed__118(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COverheadSlamAttack_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

		public float time;

		private Vector3 _003Cstart_003E5__2;

		private float _003Ct_003E5__3;

		private bool _003Chit_003E5__4;

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
		public _003COverheadSlamAttack_003Ed__119(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CRetractArmAsync_003Ed__124 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

		public float time;

		private float _003Ct_003E5__2;

		private Vector3 _003CboulderStart_003E5__3;

		private Transform _003ColdBoulderParent_003E5__4;

		private Vector3 _003CbossStart_003E5__5;

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
		public _003CRetractArmAsync_003Ed__124(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStabAttack_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Sisyphus _003C_003E4__this;

		public float time;

		private Vector3 _003Cstart_003E5__2;

		private float _003Ct_003E5__3;

		private Vector3 _003CattackTarget_003E5__4;

		private bool _003CcanCancel_003E5__5;

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
		public _003CStabAttack_003Ed__121(int _003C_003E1__state)
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

	private static readonly int s_SwingAnimSpeed;

	private float swingArmSpeed;

	private static readonly int s_OverheadSlam;

	private static readonly int s_HorizontalSwing;

	private static readonly int s_Stab;

	private static readonly int s_AirStab;

	private static readonly int s_AirStabCancel;

	private static readonly int s_Stomp;

	[SerializeField]
	private Solver3D m_Solver;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Transform m_Boulder;

	[SerializeField]
	private Collider boulderCol;

	[SerializeField]
	private PhysicalShockwave m_ShockwavePrefab;

	[SerializeField]
	private GameObject explosion;

	private Pose m_StartPose;

	private AttackType m_AttackType;

	private float[] m_NormalizedDistances;

	private Transform[] m_Transforms;

	private bool didCollide;

	private bool airStabCancelled;

	private bool pullSelfRetract;

	private bool swinging;

	private bool inAction;

	private float stuckInActionTimer;

	private int attacksPerformed;

	private int previousAttack;

	private bool previouslyJumped;

	private float cooldown;

	private NavMeshAgent nma;

	private SwingCheck2 sc;

	private float airStabOvershoot;

	private float stabOvershoot;

	private GroundCheckEnemy gce;

	private Rigidbody rb;

	private bool jumping;

	private Vector3 jumpTarget;

	private bool superJumping;

	private float trackingX;

	private float trackingY;

	private bool forceCorrectOrientation;

	private Collider col;

	[SerializeField]
	private GameObject rubble;

	[SerializeField]
	private TrailRenderer trail;

	[SerializeField]
	private ParticleSystem swingParticle;

	[SerializeField]
	private AudioSource swingAudio;

	public bool stationary;

	private AudioSource aud;

	[SerializeField]
	private AudioClip[] attackVoices;

	[SerializeField]
	private AudioClip stompVoice;

	[SerializeField]
	private AudioClip deathVoice;

	[SerializeField]
	private GameObject[] hurtSounds;

	private GameObject currentHurtSound;

	[SerializeField]
	private Transform[] legs;

	[SerializeField]
	private Transform armature;

	private int difficulty;

	[SerializeField]
	private GameObject attackFlash;

	private float stuckChecker;

	private EnemyIdentifier eid;

	private GoreZone gz;

	private Enemy mach;

	private Coroutine co;

	[SerializeField]
	private Cannonball boulderCb;

	private bool isParried;

	[SerializeField]
	private Transform originalBoulder;

	[HideInInspector]
	public bool knockedDownByCannonball;

	[SerializeField]
	private GameObject fallSound;

	private List<EnemyIdentifier> fallEnemiesHit;

	[Header("Animations")]
	[SerializeField]
	private SisyAttackAnimationDetails overheadSlamAnim;

	[SerializeField]
	private SisyAttackAnimationDetails horizontalSwingAnim;

	[SerializeField]
	private SisyAttackAnimationDetails groundStabAnim;

	[SerializeField]
	private SisyAttackAnimationDetails airStabAnim;

	[HideInInspector]
	public bool downed;

	public bool jumpOnSpawn;

	private bool dontFacePlayer;

	private float superKnockdownWindow;

	private LayerMask lmask;

	private VisionQuery visionQuery;

	private TargetData lastTargetData;

	private TargetHandle targetHandle;

	private Vector3 lastDimensionalTarget;

	public Vector3 cachedVisionPos;

	private Vision vision => null;

	private bool hasVision => false;

	private bool isVisionThroughPortal => false;

	private bool hasDimensionalTarget => false;

	private Vector3 CurrentTargetPosition => default(Vector3);

	public override Vector3 VisionSourcePosition => default(Vector3);

	private SisyAttackAnimationDetails GetAnimationDetails(AttackType type)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	private void VisionUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void ChangeArmLength(float targetLength)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private float GetDistanceToTarget()
	{
		return 0f;
	}

	private bool TestAttack(int attack)
	{
		return false;
	}

	public bool CanFit(Vector3 point)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CAirStab_003Ed__111))]
	private IEnumerator AirStab()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAirStabAttack_003Ed__112))]
	private IEnumerator AirStabAttack(float time)
	{
		return null;
	}

	public void ExtendArm(float time)
	{
	}

	public void RetractArm(float time)
	{
	}

	private Vector3 GetActualTargetPos()
	{
		return default(Vector3);
	}

	private bool SwingCheck(bool noExplosion = false)
	{
		return false;
	}

	private void SetupExplosion(GameObject temp)
	{
	}

	[IteratorStateMachine(typeof(_003CHorizontalSwingAttack_003Ed__118))]
	private IEnumerator HorizontalSwingAttack(float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COverheadSlamAttack_003Ed__119))]
	private IEnumerator OverheadSlamAttack(float time)
	{
		return null;
	}

	private void SlamShockwave()
	{
	}

	[IteratorStateMachine(typeof(_003CStabAttack_003Ed__121))]
	private IEnumerator StabAttack(float time)
	{
		return null;
	}

	public void TryToRetractArm(float time)
	{
	}

	public void SwingStop()
	{
	}

	[IteratorStateMachine(typeof(_003CRetractArmAsync_003Ed__124))]
	private IEnumerator RetractArmAsync(float time)
	{
		return null;
	}

	private void Jump(bool noEnd = false)
	{
	}

	private void Jump(Vector3 target, bool noEnd = false)
	{
	}

	private void FlyToArm()
	{
	}

	private void CancelAirStab()
	{
	}

	public void Death()
	{
	}

	private void StopAction()
	{
	}

	private void ResetBoulderPose()
	{
	}

	private void RotateTowardsTarget()
	{
	}

	public void StompExplosion()
	{
	}

	public void PlayHurtSound(int type = 0)
	{
	}

	public void GotParried()
	{
	}

	public void Knockdown(Vector3 boulderPos)
	{
	}

	public void FallSound()
	{
	}

	private void FallKillEnemy(EnemyIdentifier eid)
	{
	}

	public void CheckLoop()
	{
	}

	private void Undown()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}
}
