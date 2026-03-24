namespace Interop.core
{
	public struct flat_set<T> where T : unmanaged
	{
		public vector<T> _vector;

		[NativeTypeName("bool")]
		public byte m_sorted;
	}
	public struct flat_set<T, Allocator> where T : unmanaged where Allocator : unmanaged
	{
		public vector<T, Allocator> _vector;

		[NativeTypeName("bool")]
		public byte m_sorted;
	}
}
