namespace Interop.std
{
	public struct shared_ptr<T> where T : unmanaged
	{
		public unsafe T* _Ptr;

		public unsafe void* _Rep;
	}
}
