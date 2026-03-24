namespace Interop
{
	public struct DisposeSentinel
	{
		public int isCreated;

		[NativeTypeName("char[12]")]
		public unsafe fixed sbyte pad[12];
	}
}
