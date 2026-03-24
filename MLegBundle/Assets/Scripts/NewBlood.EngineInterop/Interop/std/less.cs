using System.Runtime.InteropServices;

namespace Interop.std
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct less<T> where T : unmanaged
	{
	}
}
