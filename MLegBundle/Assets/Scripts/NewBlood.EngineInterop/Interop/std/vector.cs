namespace Interop.std
{
	public struct vector<T> where T : unmanaged
	{
		public unsafe T* begin;

		public unsafe T* end;

		public unsafe T* capacity;
	}
	public struct vector<T, Allocator> where T : unmanaged where Allocator : unmanaged
	{
		private const string EmptyAllocatorMessage = "vector<T, Allocator> does not support empty allocator types, use vector<T> instead.";

		[DisallowEmptyType("vector<T, Allocator> does not support empty allocator types, use vector<T> instead.")]
		public Allocator allocator;

		public unsafe T* begin;

		public unsafe T* end;

		public unsafe T* capacity;
	}
}
