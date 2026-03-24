namespace Interop
{
	[SupportsInheritance]
	public struct Coroutine : Coroutine.Interface, IUpCastable<Coroutine>, ListElement.Interface, IUpCastable<ListElement>
	{
		public interface Interface : IUpCastable<Coroutine>, ListElement.Interface, IUpCastable<ListElement>
		{
		}

		[BaseField]
		private ListElement __ListElement;

		public ScriptingGCHandle m_CoroutineEnumeratorGCHandle;

		public ScriptingGCHandle m_CoroutineGCHandle;

		public ScriptingMethodPtr m_CoroutineMethod;

		public ScriptingMethodPtr m_MoveNext;

		public ScriptingMethodPtr m_Current;

		public unsafe MonoBehaviour* m_Behaviour;

		public int m_RefCount;

		[NativeTypeName("bool")]
		public byte m_DoneRunning;

		public unsafe Coroutine* m_ContinueWhenFinished;

		public unsafe Coroutine* m_WaitingFor;

		public unsafe AsyncOperation* m_AsyncOperation;

		[NativeTypeName("bool")]
		public byte m_IsIEnumeratorCoroutine;

		unsafe ref Coroutine IUpCastable<Coroutine>.Cast()
		{
			return ref *(Coroutine*)null;
		}

		unsafe ref ListElement IUpCastable<ListElement>.Cast()
		{
			return ref *(ListElement*)null;
		}
	}
}
