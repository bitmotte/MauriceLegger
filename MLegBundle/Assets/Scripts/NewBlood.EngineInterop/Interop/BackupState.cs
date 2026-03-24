using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[NonCopyable]
	[IncompleteType]
	public struct BackupState
	{
	}
}
