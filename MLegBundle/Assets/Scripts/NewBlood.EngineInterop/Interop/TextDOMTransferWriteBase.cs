namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct TextDOMTransferWriteBase<T> : TextDOMTransferWriteBase<T>.Interface, IUpCastable<TextDOMTransferWriteBase<T>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<TextDOMTransferWriteBase<T>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref TextDOMTransferWriteBase<T> IUpCastable<TextDOMTransferWriteBase<T>>.Cast()
		{
			return ref *(TextDOMTransferWriteBase<T>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
