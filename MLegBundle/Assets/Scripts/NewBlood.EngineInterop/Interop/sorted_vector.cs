using Interop.std;

namespace Interop
{
	[SupportsInheritance]
	public struct sorted_vector<Key> : sorted_vector<Key>.Interface, IUpCastable<sorted_vector<Key>> where Key : unmanaged
	{
		public interface Interface : IUpCastable<sorted_vector<Key>>
		{
		}

		public vector<Key> c;

		unsafe ref sorted_vector<Key> IUpCastable<sorted_vector<Key>>.Cast()
		{
			return ref *(sorted_vector<Key>*)null;
		}
	}
	[SupportsInheritance]
	public struct sorted_vector<Key, Compare, Allocator> : sorted_vector<Key, Compare, Allocator>.Interface, IUpCastable<sorted_vector<Key, Compare, Allocator>> where Key : unmanaged where Compare : unmanaged where Allocator : unmanaged
	{
		public interface Interface : IUpCastable<sorted_vector<Key, Compare, Allocator>>
		{
		}

		public Compare __base;

		public vector<Key, Allocator> c;

		unsafe ref sorted_vector<Key, Compare, Allocator> IUpCastable<sorted_vector<Key, Compare, Allocator>>.Cast()
		{
			return ref *(sorted_vector<Key, Compare, Allocator>*)null;
		}
	}
}
