namespace Interop.core.impl
{
	[SupportsInheritance]
	public struct allocator_shared<T> : allocator_shared<T>.Interface, IUpCastable<allocator_shared<T>>
	{
		public interface Interface : IUpCastable<allocator_shared<T>>
		{
		}

		public MemLabelId m_label;

		unsafe ref allocator_shared<T> IUpCastable<allocator_shared<T>>.Cast()
		{
			return ref *(allocator_shared<T>*)null;
		}
	}
}
