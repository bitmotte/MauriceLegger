namespace Interop
{
	public struct ConstantString
	{
		[NativeTypeName("char const *")]
		public unsafe sbyte* m_Buffer;
	}
}
