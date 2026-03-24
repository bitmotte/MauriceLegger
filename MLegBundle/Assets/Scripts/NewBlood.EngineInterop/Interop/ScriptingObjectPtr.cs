namespace Interop
{
	[SupportsInheritance]
	public struct ScriptingObjectPtr : ScriptingObjectPtr.Interface, IUpCastable<ScriptingObjectPtr>
	{
		public interface Interface : IUpCastable<ScriptingObjectPtr>
		{
		}

		[NativeTypeName("ScriptingBackendNativeObjectPtr")]
		public unsafe void* m_Target;

		unsafe ref ScriptingObjectPtr IUpCastable<ScriptingObjectPtr>.Cast()
		{
			return ref *(ScriptingObjectPtr*)null;
		}
	}
}
