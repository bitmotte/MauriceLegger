namespace Interop.audio.memory
{
	[SupportsInheritance]
	public struct HeapAllocator : HeapAllocator.Interface, IUpCastable<HeapAllocator>, RuntimeBaseAllocator.Interface, IUpCastable<RuntimeBaseAllocator>
	{
		public interface Interface : IUpCastable<HeapAllocator>, RuntimeBaseAllocator.Interface, IUpCastable<RuntimeBaseAllocator>
		{
		}

		[BaseField]
		private RuntimeBaseAllocator __RuntimeBaseAllocator;

		public MemLabelId m_Label;

		unsafe ref HeapAllocator IUpCastable<HeapAllocator>.Cast()
		{
			return ref *(HeapAllocator*)null;
		}

		unsafe ref RuntimeBaseAllocator IUpCastable<RuntimeBaseAllocator>.Cast()
		{
			return ref *(RuntimeBaseAllocator*)null;
		}
	}
}
