using Interop.std;

namespace Interop
{
	[SupportsInheritance]
	public struct sorted_vector_empty_allocator<Key, Compare> : sorted_vector_empty_allocator<Key, Compare>.Interface, IUpCastable<sorted_vector_empty_allocator<Key, Compare>> where Key : unmanaged where Compare : unmanaged
	{
		public interface Interface : IUpCastable<sorted_vector_empty_allocator<Key, Compare>>
		{
		}

		public Compare __base;

		public vector<Key> c;

		unsafe ref sorted_vector_empty_allocator<Key, Compare> IUpCastable<sorted_vector_empty_allocator<Key, Compare>>.Cast()
		{
			return ref *(sorted_vector_empty_allocator<Key, Compare>*)null;
		}
	}
}
