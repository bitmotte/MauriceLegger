using System.Runtime.InteropServices;

namespace Interop
{
	public struct SoundHandle
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		[IncompleteType]
		public struct Instance
		{
		}

		public WeakPtr<Instance> m_WeakPtr;
	}
}
