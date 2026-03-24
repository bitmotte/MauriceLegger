using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public static class GetMissionName
{
	[CompilerGenerated]
	private sealed class _003CEnumerateMissionNumbers_003Ed__4 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int _003Ci_003E5__2;

		int IEnumerator<int>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0;
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
		public _003CEnumerateMissionNumbers_003Ed__4(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static string GetMission(int missionNum)
	{
		return null;
	}

	public static string GetMissionNumberOnly(int missionNum)
	{
		return null;
	}

	public static string GetMissionNameOnly(int missionNum)
	{
		return null;
	}

	public static string GetSceneName(int missionNum)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnumerateMissionNumbers_003Ed__4))]
	public static IEnumerable<int> EnumerateMissionNumbers()
	{
		return null;
	}
}
