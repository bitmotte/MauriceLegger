using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LegController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAdjustBodyTransform_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LegController _003C_003E4__this;

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
		public _003CAdjustBodyTransform_003Ed__15(int _003C_003E1__state)
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

	[SerializeField]
	private Transform bodyTransform;

	[SerializeField]
	private Leg[] legs;

	private float maxTipWait;

	private bool readySwitchOrder;

	private bool stepOrder;

	private float bodyHeightBase;

	private Vector3 bodyPos;

	private Vector3 bodyUp;

	private Vector3 bodyForward;

	private Vector3 bodyRight;

	private Quaternion bodyRotation;

	private float PosAdjustRatio;

	private float RotAdjustRatio;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CAdjustBodyTransform_003Ed__15))]
	private IEnumerator AdjustBodyTransform()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
