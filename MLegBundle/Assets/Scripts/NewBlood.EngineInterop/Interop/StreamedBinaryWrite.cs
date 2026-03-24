namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct StreamedBinaryWrite : StreamedBinaryWrite.Interface, IUpCastable<StreamedBinaryWrite>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<StreamedBinaryWrite>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref StreamedBinaryWrite IUpCastable<StreamedBinaryWrite>.Cast()
		{
			return ref *(StreamedBinaryWrite*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
