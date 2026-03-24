namespace Interop.core
{
	public struct flat_map<Key, T> where Key : unmanaged where T : unmanaged
	{
		public flat_set<pair<Key, T>> _flat_set;
	}
}
