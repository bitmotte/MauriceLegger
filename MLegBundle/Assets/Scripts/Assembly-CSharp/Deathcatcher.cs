using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Deathcatcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRespawnPuppets_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Deathcatcher _003C_003E4__this;

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
		public _003CRespawnPuppets_003Ed__29(int _003C_003E1__state)
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

	public bool active;

	public bool canRespawnIdols;

	private int difficulty;

	private EnemyIdentifier eid;

	private CapsuleCollider col;

	private GoreZone affectedGoreZone;

	private readonly List<CaughtEnemy> deadCaughtEnemies;

	public float respawnDelay;

	[HideInInspector]
	public float countdownToRespawn;

	private TimeSince timeSinceRespawn;

	public MeshRenderer chargeSphere;

	private AudioSource chargeAud;

	private MaterialPropertyBlock block;

	public GameObject respawnEffect;

	private bool dead;

	[SerializeField]
	private GameObject deathParticle;

	public bool killPuppetsOnDeath;

	public GameObject closedModel;

	public GameObject openingModel;

	public GameObject openModel;

	private Animator anim;

	public GameObject[] effectsWhenOpen;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void EnemyDeath(EnemyIdentifier eid)
	{
	}

	private void OnGUI()
	{
	}

	private void SlowUpdate()
	{
	}

	private float TimeUntilRespawn()
	{
		return 0f;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRespawnPuppets_003Ed__29))]
	private IEnumerator RespawnPuppets()
	{
		return null;
	}

	public void Death()
	{
	}

	public void IsActive(bool newState)
	{
	}

	public bool TryGetPuppet(int originalID, out GameObject puppet)
	{
		puppet = null;
		return false;
	}

	public void ChangeAnimationState(bool open)
	{
	}

	public void Opened()
	{
	}
}
