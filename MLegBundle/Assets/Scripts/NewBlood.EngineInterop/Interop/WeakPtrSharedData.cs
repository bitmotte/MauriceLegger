namespace Interop
{
	[SupportsInheritance]
	public struct WeakPtrSharedData : WeakPtrSharedData.Interface, IUpCastable<WeakPtrSharedData>, ThreadSharedObject<WeakPtrSharedData>.Interface, IUpCastable<ThreadSharedObject<WeakPtrSharedData>>, SharedObject<WeakPtrSharedData>.Interface, IUpCastable<SharedObject<WeakPtrSharedData>>
	{
		public interface Interface : IUpCastable<WeakPtrSharedData>, ThreadSharedObject<WeakPtrSharedData>.Interface, IUpCastable<ThreadSharedObject<WeakPtrSharedData>>, SharedObject<WeakPtrSharedData>.Interface, IUpCastable<SharedObject<WeakPtrSharedData>>
		{
		}

		[BaseField]
		private ThreadSharedObject<WeakPtrSharedData> __ThreadSharedObject;

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
}
