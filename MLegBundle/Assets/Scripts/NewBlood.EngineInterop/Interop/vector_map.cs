using Interop.std;

namespace Interop
{
	[SupportsInheritance]
	public struct vector_map<Key, T, Compare> : vector_map<Key, T, Compare>.Interface, IUpCastable<vector_map<Key, T, Compare>>, sorted_vector_empty_allocator<pair<Key, T>, vector_map<Key, T, Compare>.value_compare>.Interface, IUpCastable<sorted_vector_empty_allocator<pair<Key, T>, vector_map<Key, T, Compare>.value_compare>> where Key : unmanaged where T : unmanaged where Compare : unmanaged
	{
		[SupportsInheritance]
		public struct value_compare : value_compare.Interface, IUpCastable<value_compare>, function.Interface, IUpCastable<function>
		{
			public interface Interface : IUpCastable<value_compare>, function.Interface, IUpCastable<function>
			{
			}

			[BaseField]
			private function __function;

			public Compare comp;

			unsafe ref value_compare IUpCastable<value_compare>.Cast()
			{
				return ref *(value_compare*)null;
			}

			unsafe ref function IUpCastable<function>.Cast()
			{
				return ref *(function*)null;
			}
		}

		public interface Interface : IUpCastable<vector_map<Key, T, Compare>>, sorted_vector_empty_allocator<pair<Key, T>, value_compare>.Interface, IUpCastable<sorted_vector_empty_allocator<pair<Key, T>, value_compare>>
		{
		}

		[BaseField]
		private sorted_vector_empty_allocator<pair<Key, T>, value_compare> __sorted_vector;

		unsafe ref vector_map<Key, T, Compare> IUpCastable<vector_map<Key, T, Compare>>.Cast()
		{
			return ref *(vector_map<Key, T, Compare>*)null;
		}

		unsafe ref sorted_vector_empty_allocator<pair<Key, T>, value_compare> IUpCastable<sorted_vector_empty_allocator<pair<Key, T>, value_compare>>.Cast()
		{
			return ref *(sorted_vector_empty_allocator<pair<Key, T>, value_compare>*)null;
		}
	}
	[SupportsInheritance]
	public struct vector_map<Key, T, Compare, Allocator> : vector_map<Key, T, Compare, Allocator>.Interface, IUpCastable<vector_map<Key, T, Compare, Allocator>>, sorted_vector<pair<Key, T>, vector_map<Key, T, Compare, Allocator>.value_compare, Allocator>.Interface, IUpCastable<sorted_vector<pair<Key, T>, vector_map<Key, T, Compare, Allocator>.value_compare, Allocator>> where Key : unmanaged where T : unmanaged where Compare : unmanaged where Allocator : unmanaged
	{
		[SupportsInheritance]
		public struct value_compare : value_compare.Interface, IUpCastable<value_compare>, function.Interface, IUpCastable<function>
		{
			public interface Interface : IUpCastable<value_compare>, function.Interface, IUpCastable<function>
			{
			}

			[BaseField]
			private function __function;

			public Compare comp;

			unsafe ref value_compare IUpCastable<value_compare>.Cast()
			{
				return ref *(value_compare*)null;
			}

			unsafe ref function IUpCastable<function>.Cast()
			{
				return ref *(function*)null;
			}
		}

		public interface Interface : IUpCastable<vector_map<Key, T, Compare, Allocator>>, sorted_vector<pair<Key, T>, value_compare, Allocator>.Interface, IUpCastable<sorted_vector<pair<Key, T>, value_compare, Allocator>>
		{
		}

		[BaseField]
		private sorted_vector<pair<Key, T>, value_compare, Allocator> __sorted_vector;

		unsafe ref vector_map<Key, T, Compare, Allocator> IUpCastable<vector_map<Key, T, Compare, Allocator>>.Cast()
		{
			return ref *(vector_map<Key, T, Compare, Allocator>*)null;
		}

		unsafe ref sorted_vector<pair<Key, T>, value_compare, Allocator> IUpCastable<sorted_vector<pair<Key, T>, value_compare, Allocator>>.Cast()
		{
			return ref *(sorted_vector<pair<Key, T>, value_compare, Allocator>*)null;
		}
	}
}
