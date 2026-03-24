using Microsoft.CodeAnalysis;

namespace Interop.mecanim.memory
{
	[NonCopyable]
	[SupportsInheritance]
	public struct ChainedAllocator : ChainedAllocator.Interface, IUpCastable<ChainedAllocator>, RuntimeBaseAllocator.Interface, IUpCastable<RuntimeBaseAllocator>
	{
		public struct MemoryBlock
		{
			public unsafe MemoryBlock* next;

			public unsafe byte* headPtr;

			public nuint blockSize;
		}

		public struct Vtbl<T> where T : unmanaged, Interface
		{
			public RuntimeBaseAllocator.Vtbl<T> __base;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> Reset;

			[NativeTypeName("bool (uint64_t const &, uint64_t const &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, nuint*, nuint*, byte> AllocateNewBlock;
		}

		public interface Interface : IUpCastable<ChainedAllocator>, RuntimeBaseAllocator.Interface, IUpCastable<RuntimeBaseAllocator>
		{
		}

		[BaseField]
		private RuntimeBaseAllocator __RuntimeBaseAllocator;

		public unsafe MemoryBlock* first;

		public unsafe MemoryBlock* current;

		public unsafe byte* heapPtr;

		public nuint blockSize;

		public MemLabelId label;

		unsafe ref ChainedAllocator IUpCastable<ChainedAllocator>.Cast()
		{
			return ref *(ChainedAllocator*)null;
		}

		unsafe ref RuntimeBaseAllocator IUpCastable<RuntimeBaseAllocator>.Cast()
		{
			return ref *(RuntimeBaseAllocator*)null;
		}
	}
}
