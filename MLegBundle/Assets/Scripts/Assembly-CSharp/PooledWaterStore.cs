using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PooledWaterStore : MonoSingleton<PooledWaterStore>
{
	[CompilerGenerated]
	private sealed class _003CInitPool_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PooledWaterStore _003C_003E4__this;

		public Water.WaterGOType type;

		private Queue<GameObject> _003Cqueue_003E5__2;

		private AsyncInstantiateOperation<GameObject> _003CasyncOp_003E5__3;

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
		public _003CInitPool_003Ed__10(int _003C_003E1__state)
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

	private GameObject smallSplash;

	private GameObject bigSplash;

	private GameObject continuousSplash;

	private GameObject bubblePrefab;

	private GameObject wetParticle;

	private Dictionary<Water.WaterGOType, Queue<GameObject>> waterGOQueues;

	private Transform thisTrans;

	private void Start()
	{
	}

	private void InitPools()
	{
	}

	private GameObject GetPrefabByWaterType(Water.WaterGOType waterType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitPool_003Ed__10))]
	private IEnumerator InitPool(Water.WaterGOType type)
	{
		return null;
	}

	public GameObject GetFromQueue(Water.WaterGOType type)
	{
		return null;
	}

	public void ReturnToQueue(GameObject go, Water.WaterGOType type)
	{
	}
}
