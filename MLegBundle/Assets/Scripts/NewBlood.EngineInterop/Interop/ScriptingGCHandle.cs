using System.Runtime.InteropServices;

namespace Interop
{
	public struct ScriptingGCHandle
	{
		public GCHandle m_Handle;

		public ScriptingGCHandleWeakness m_Weakness;

		public ScriptingObjectPtr m_Object;
	}
}
