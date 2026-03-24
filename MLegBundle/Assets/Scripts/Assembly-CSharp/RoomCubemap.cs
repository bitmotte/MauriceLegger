using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoomCubemap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateCubeMapNextFrame_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomCubemap _003C_003E4__this;

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
		public _003CUpdateCubeMapNextFrame_003Ed__13(int _003C_003E1__state)
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

	public int startRecursions;

	public bool automaticPosition;

	public CubemapMode cubemapMode;

	public float cubemapStrength;

	public List<MeshRenderer> additionalRenderers;

	private Transform room;

	private MeshRenderer[] roomObjects;

	private Bounds roomBounds;

	private Cubemap cubemap;

	private Camera cam;

	private MaterialPropertyBlock propertyBlock;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCubeMapNextFrame_003Ed__13))]
	private IEnumerator UpdateCubeMapNextFrame()
	{
		return null;
	}

	public void UpdateCubemap()
	{
	}

	public void DelayUpdate(float delayTime)
	{
	}
}
