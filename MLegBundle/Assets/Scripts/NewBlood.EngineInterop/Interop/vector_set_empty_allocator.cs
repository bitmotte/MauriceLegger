namespace Interop
{
	[SupportsInheritance]
	public struct vector_set_empty_allocator<Key, Compare> : vector_set_empty_allocator<Key, Compare>.Interface, IUpCastable<vector_set_empty_allocator<Key, Compare>>, sorted_vector_empty_allocator<Key, Compare>.Interface, IUpCastable<sorted_vector_empty_allocator<Key, Compare>> where Key : unmanaged where Compare : unmanaged
	{
		public interface Interface : IUpCastable<vector_set_empty_allocator<Key, Compare>>, sorted_vector_empty_allocator<Key, Compare>.Interface, IUpCastable<sorted_vector_empty_allocator<Key, Compare>>
		{
		}

		[BaseField]
		private sorted_vector_empty_allocator<Key, Compare> __sorted_vector;

		unsafe ref vector_set_empty_allocator<Key, Compare> IUpCastable<vector_set_empty_allocator<Key, Compare>>.Cast()
		{
			return ref *(vector_set_empty_allocator<Key, Compare>*)null;
		}

		unsafe ref sorted_vector_empty_allocator<Key, Compare> IUpCastable<sorted_vector_empty_allocator<Key, Compare>>.Cast()
		{
			return ref *(sorted_vector_empty_allocator<Key, Compare>*)null;
		}
	}
}
