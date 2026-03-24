namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct JSONWrite : JSONWrite.Interface, IUpCastable<JSONWrite>, TextDOMTransferWriteBase<JSONWrite>.Interface, IUpCastable<TextDOMTransferWriteBase<JSONWrite>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<JSONWrite>, TextDOMTransferWriteBase<JSONWrite>.Interface, IUpCastable<TextDOMTransferWriteBase<JSONWrite>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TextDOMTransferWriteBase<JSONWrite> __TextDOMTransferWriteBase;

		unsafe ref JSONWrite IUpCastable<JSONWrite>.Cast()
		{
			return ref *(JSONWrite*)null;
		}

		unsafe ref TextDOMTransferWriteBase<JSONWrite> IUpCastable<TextDOMTransferWriteBase<JSONWrite>>.Cast()
		{
			return ref *(TextDOMTransferWriteBase<JSONWrite>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
