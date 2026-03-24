namespace Interop
{
	[SupportsInheritance]
	public struct ThreadSharedObject<T> : ThreadSharedObject<T>.Interface, IUpCastable<ThreadSharedObject<T>>, SharedObject<T>.Interface, IUpCastable<SharedObject<T>>
	{
		public interface Interface : IUpCastable<ThreadSharedObject<T>>, SharedObject<T>.Interface, IUpCastable<SharedObject<T>>
		{
		}

		[BaseField]
		private SharedObject<T> __SharedObject;

		unsafe ref ThreadSharedObject<T> IUpCastable<ThreadSharedObject<T>>.Cast()
		{
			return ref *(ThreadSharedObject<T>*)null;
		}

		unsafe ref SharedObject<T> IUpCastable<SharedObject<T>>.Cast()
		{
			return ref *(SharedObject<T>*)null;
		}
	}
}
