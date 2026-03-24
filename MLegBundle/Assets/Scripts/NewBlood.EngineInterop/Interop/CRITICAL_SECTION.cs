namespace Interop
{
	public struct CRITICAL_SECTION
	{
		[NativeTypeName("PRTL_CRITICAL_SECTION_DEBUG")]
		public unsafe void* DebugInfo;

		[NativeTypeName("LONG")]
		public int LockCount;

		[NativeTypeName("LONG")]
		public int RecursionCount;

		[NativeTypeName("HANDLE")]
		public unsafe void* OwningThread;

		[NativeTypeName("HANDLE")]
		public unsafe void* LockSemaphore;

		[NativeTypeName("ULONG_PTR")]
		public nuint SpinCount;
	}
}
