using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[NonCopyable]
	[SupportsInheritance]
	public struct NonCopyable : NonCopyable.Interface, IUpCastable<NonCopyable>
	{
		public interface Interface : IUpCastable<NonCopyable>
		{
		}

		unsafe ref NonCopyable IUpCastable<NonCopyable>.Cast()
		{
			return ref *(NonCopyable*)null;
		}
	}
}
