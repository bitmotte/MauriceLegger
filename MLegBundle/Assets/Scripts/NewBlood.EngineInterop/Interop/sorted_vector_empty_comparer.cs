using Interop.std;

namespace Interop
{
	[SupportsInheritance]
	public struct sorted_vector_empty_comparer<Key, Allocator> : sorted_vector_empty_comparer<Key, Allocator>.Interface, IUpCastable<sorted_vector_empty_comparer<Key, Allocator>> where Key : unmanaged where Allocator : unmanaged
	{
		public interface Interface : IUpCastable<sorted_vector_empty_comparer<Key, Allocator>>
		{
		}

		public vector<Key, Allocator> c;

		unsafe ref sorted_vector_empty_comparer<Key, Allocator> IUpCastable<sorted_vector_empty_comparer<Key, Allocator>>.Cast()
		{
			return ref *(sorted_vector_empty_comparer<Key, Allocator>*)null;
		}
	}
}
