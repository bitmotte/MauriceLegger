namespace Interop.core
{
	public struct SharedObjectPtr<T> where T : unmanaged
	{
		public unsafe void* All_SharedObjectPtrs_must_be_initialised_on_a_class_derived_from_SharedObject;

		public unsafe T* m_Ptr;
	}
}
