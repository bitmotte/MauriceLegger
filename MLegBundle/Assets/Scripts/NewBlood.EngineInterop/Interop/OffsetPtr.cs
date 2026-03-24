namespace Interop
{
	public struct OffsetPtr<T> where T : unmanaged
	{
		public nuint m_Offset;

		public readonly bool IsNull()
		{
			return false;
		}

		public unsafe readonly T* Get()
		{
			//IL_0002: Expected I, but got O
			return (T*)unchecked((nint)0);
		}
	}
}
