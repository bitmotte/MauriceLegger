namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct TextDOMTransferReadBase<T> : TextDOMTransferReadBase<T>.Interface, IUpCastable<TextDOMTransferReadBase<T>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<TextDOMTransferReadBase<T>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref TextDOMTransferReadBase<T> IUpCastable<TextDOMTransferReadBase<T>>.Cast()
		{
			return ref *(TextDOMTransferReadBase<T>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
