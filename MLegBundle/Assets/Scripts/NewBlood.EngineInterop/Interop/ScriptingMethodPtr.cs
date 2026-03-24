namespace Interop
{
	public struct ScriptingMethodPtr
	{
		[NativeTypeName("ScriptingBackendNativeMethodPtr")]
		public unsafe void* m_BackendMethod;
	}
}
