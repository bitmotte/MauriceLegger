namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct RemapPPtrTransfer : RemapPPtrTransfer.Interface, IUpCastable<RemapPPtrTransfer>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<RemapPPtrTransfer>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref RemapPPtrTransfer IUpCastable<RemapPPtrTransfer>.Cast()
		{
			return ref *(RemapPPtrTransfer*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
