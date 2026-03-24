namespace Interop
{
	public struct WeakPtr<T> where T : unmanaged
	{
		[SupportsInheritance]
		public struct SharedData : SharedData.Interface, IUpCastable<SharedData>, WeakPtrSharedData.Interface, IUpCastable<WeakPtrSharedData>, ThreadSharedObject<WeakPtrSharedData>.Interface, IUpCastable<ThreadSharedObject<WeakPtrSharedData>>, SharedObject<WeakPtrSharedData>.Interface, IUpCastable<SharedObject<WeakPtrSharedData>>
		{
			public interface Interface : IUpCastable<SharedData>, WeakPtrSharedData.Interface, IUpCastable<WeakPtrSharedData>, ThreadSharedObject<WeakPtrSharedData>.Interface, IUpCastable<ThreadSharedObject<WeakPtrSharedData>>, SharedObject<WeakPtrSharedData>.Interface, IUpCastable<SharedObject<WeakPtrSharedData>>
			{
			}

			[BaseField]
			private WeakPtrSharedData __WeakPtrSharedData;

			public unsafe T* m_Ptr;

			unsafe ref SharedData IUpCastable<SharedData>.Cast()
			{
				return ref *(SharedData*)null;
			}

			unsafe ref WeakPtrSharedData IUpCastable<WeakPtrSharedData>.Cast()
			{
				return ref *(WeakPtrSharedData*)null;
			}

			unsafe ref ThreadSharedObject<WeakPtrSharedData> IUpCastable<ThreadSharedObject<WeakPtrSharedData>>.Cast()
			{
				return ref *(ThreadSharedObject<WeakPtrSharedData>*)null;
			}

			unsafe ref SharedObject<WeakPtrSharedData> IUpCastable<SharedObject<WeakPtrSharedData>>.Cast()
			{
				return ref *(SharedObject<WeakPtrSharedData>*)null;
			}
		}

		public unsafe SharedData* m_SharedData;
	}
}
