using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Leg : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateLeg_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Leg _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private Vector3 _003CstartingTipPos_003E5__3;

		private Vector3 _003CtipDirVec_003E5__4;

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
		public _003CAnimateLeg_003Ed__44(int _003C_003E1__state)
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

	private LegController legController;

	[SerializeField]
	private Transform bodyTransform;

	[SerializeField]
	private Transform rayOrigin;

	public GameObject ikTarget;

	[SerializeField]
	private AnimationCurve speedCurve;

	[SerializeField]
	private AnimationCurve heightCurve;

	private float tipMaxHeight;

	private float tipAnimationTime;

	private float tipAnimationFrameTime;

	private float ikOffset;

	private float tipMoveDist;

	private float maxRayDist;

	private float tipPassOver;

	public Vector3 TipPos { get; private set; }

	public Vector3 TipUpDir { get; private set; }

	public Vector3 RaycastTipPos { get; private set; }

	public Vector3 RaycastTipNormal { get; private set; }

	public bool Animating { get; private set; }

	public bool Movable { get; set; }

	public float TipDistance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateLeg_003Ed__44))]
	private IEnumerator AnimateLeg()
	{
		return null;
	}

	private void UpdateIKTargetTransform()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
