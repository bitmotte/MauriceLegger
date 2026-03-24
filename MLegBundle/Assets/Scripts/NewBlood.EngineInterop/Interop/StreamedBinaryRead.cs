namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct StreamedBinaryRead : StreamedBinaryRead.Interface, IUpCastable<StreamedBinaryRead>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<StreamedBinaryRead>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref StreamedBinaryRead IUpCastable<StreamedBinaryRead>.Cast()
		{
			return ref *(StreamedBinaryRead*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
