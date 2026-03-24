using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IKFootSolver : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateLeg_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IKFootSolver _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private Vector3 _003CstartingTipPos_003E5__3;

		private Vector3 _003CtipDirVec_003E5__4;

		private bool _003CstartedNextFoot_003E5__5;

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
		public _003CAnimateLeg_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CWaitForStopAnimating_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IKFootSolver _003C_003E4__this;

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
		public _003CWaitForStopAnimating_003Ed__37(int _003C_003E1__state)
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

	private Transform root;

	public Transform rayStart;

	public Transform footTarget;

	private FootController fC;

	[SerializeField]
	private AnimationCurve heightCurve;

	private float maxRayDist;

	private float tipPassOver;

	[HideInInspector]
	public bool animating;

	private bool needsToMove;

	private Quaternion initialRotRelation;

	private AudioSource aud;

	[SerializeField]
	private AudioClip[] footsteps;

	public Vector3 TipPos { get; private set; }

	public Vector3 TipUpDir { get; private set; }

	public Vector3 RaycastTipPos { get; private set; }

	public Vector3 RaycastTipNormal { get; private set; }

	public float TipDistance { get; private set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public bool HasHitTargetPosition()
	{
		return false;
	}

	public void StartLegAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForStopAnimating_003Ed__37))]
	private IEnumerator WaitForStopAnimating()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAnimateLeg_003Ed__38))]
	private IEnumerator AnimateLeg()
	{
		return null;
	}

	private void UpdateIKTargetTransform()
	{
	}
}
