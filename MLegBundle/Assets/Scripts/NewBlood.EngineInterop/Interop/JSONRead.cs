namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct JSONRead : JSONRead.Interface, IUpCastable<JSONRead>, TextDOMTransferReadBase<JSONRead>.Interface, IUpCastable<TextDOMTransferReadBase<JSONRead>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<JSONRead>, TextDOMTransferReadBase<JSONRead>.Interface, IUpCastable<TextDOMTransferReadBase<JSONRead>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TextDOMTransferReadBase<JSONRead> __TextDOMTransferReadBase;

		unsafe ref JSONRead IUpCastable<JSONRead>.Cast()
		{
			return ref *(JSONRead*)null;
		}

		unsafe ref TextDOMTransferReadBase<JSONRead> IUpCastable<TextDOMTransferReadBase<JSONRead>>.Cast()
		{
			return ref *(TextDOMTransferReadBase<JSONRead>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
