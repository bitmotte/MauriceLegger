namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct YAMLRead : YAMLRead.Interface, IUpCastable<YAMLRead>, TextDOMTransferReadBase<YAMLRead>.Interface, IUpCastable<TextDOMTransferReadBase<YAMLRead>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<YAMLRead>, TextDOMTransferReadBase<YAMLRead>.Interface, IUpCastable<TextDOMTransferReadBase<YAMLRead>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TextDOMTransferReadBase<YAMLRead> __TextDOMTransferReadBase;

		unsafe ref YAMLRead IUpCastable<YAMLRead>.Cast()
		{
			return ref *(YAMLRead*)null;
		}

		unsafe ref TextDOMTransferReadBase<YAMLRead> IUpCastable<TextDOMTransferReadBase<YAMLRead>>.Cast()
		{
			return ref *(TextDOMTransferReadBase<YAMLRead>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
