using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManagementScreen : MonoBehaviour
{
	public struct CachedLevelScore
	{
		public int? anyPercentScore;

		public bool anyPercentInvalid;

		public int? pRankScore;

		public bool pRankInvalid;
	}

	[CompilerGenerated]
	private sealed class _003CFetchCoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeaderboardManagementScreen _003C_003E4__this;

		private int _003CmissionNum_003E5__2;

		private string _003CsceneName_003E5__3;

		private Task<int?> _003CanyTask_003E5__4;

		private Task<int?> _003CpRankTask_003E5__5;

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
		public _003CFetchCoroutine_003Ed__20(int _003C_003E1__state)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRequestReset_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string boardKey;

		public LeaderboardManagementScreen _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private LeaderboardManagementEntry template;

	[SerializeField]
	private Transform container;

	[SerializeField]
	private GameObject loadingPanel;

	[SerializeField]
	private Button refreshAllButton;

	[SerializeField]
	private GameObject autoFixOverlay;

	[SerializeField]
	private TMP_Text autoFixDetailsText;

	[SerializeField]
	private BasicConfirmationDialog autoFixDoneDialog;

	[SerializeField]
	private TMP_Text autoFixSummary;

	private readonly Dictionary<string, LeaderboardManagementEntry> entries;

	private readonly Dictionary<string, CachedLevelScore> scoreCache;

	private readonly List<int> fetchQueue;

	private Coroutine fetchCoroutine;

	private bool fetchComplete;

	private bool autoFix;

	private int pendingFetchCount;

	private int autoFixPendingCount;

	private int autoFixedCount;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CFetchCoroutine_003Ed__20))]
	private IEnumerator FetchCoroutine()
	{
		return null;
	}

	private void UpdateEntry(int missionNum, string sceneName, CachedLevelScore cached)
	{
	}

	private void UpdateAutoFixDetails()
	{
	}

	private void SetFetchPending(bool pending)
	{
	}

	private void ClearCache()
	{
	}

	public void RefreshAll()
	{
	}

	public void StartAutoFix()
	{
	}

	[AsyncStateMachine(typeof(_003CRequestReset_003Ed__27))]
	public void RequestReset(string boardKey)
	{
	}
}
