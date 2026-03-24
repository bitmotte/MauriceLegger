namespace Interop.core
{
	public struct unique_ptr<T> where T : unmanaged
	{
		public unsafe T* m_Ptr;

		public MemLabelId m_MemLabel;
	}
}
