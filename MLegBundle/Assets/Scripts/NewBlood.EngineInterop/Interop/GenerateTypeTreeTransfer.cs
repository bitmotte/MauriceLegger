namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct GenerateTypeTreeTransfer : GenerateTypeTreeTransfer.Interface, IUpCastable<GenerateTypeTreeTransfer>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<GenerateTypeTreeTransfer>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref GenerateTypeTreeTransfer IUpCastable<GenerateTypeTreeTransfer>.Cast()
		{
			return ref *(GenerateTypeTreeTransfer*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
