namespace Interop
{
	public struct Baselib_ReentrantLock
	{
		public Baselib_Lock @lock;

		[NativeTypeName("UnityClassic::Baselib_Thread_Id")]
		public nint owner;

		public int count;
	}
}
