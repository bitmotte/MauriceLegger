using System.Runtime.InteropServices;

namespace Interop
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[IncompleteType]
	[SupportsInheritance]
	public struct TransferBase : TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<TransferBase>
		{
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
