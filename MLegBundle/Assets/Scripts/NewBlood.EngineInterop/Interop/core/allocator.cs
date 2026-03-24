using Interop.core.impl;

namespace Interop.core
{
	[SupportsInheritance]
	public struct allocator<T> : allocator<T>.Interface, IUpCastable<allocator<T>>, allocator_shared<T>.Interface, IUpCastable<allocator_shared<T>>
	{
		public interface Interface : IUpCastable<allocator<T>>, allocator_shared<T>.Interface, IUpCastable<allocator_shared<T>>
		{
		}

		[BaseField]
		private allocator_shared<T> __allocator_shared;

		unsafe ref allocator<T> IUpCastable<allocator<T>>.Cast()
		{
			return ref *(allocator<T>*)null;
		}

		unsafe ref allocator_shared<T> IUpCastable<allocator_shared<T>>.Cast()
		{
			return ref *(allocator_shared<T>*)null;
		}
	}
}
