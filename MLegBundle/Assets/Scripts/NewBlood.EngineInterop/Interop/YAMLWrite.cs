namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct YAMLWrite : YAMLWrite.Interface, IUpCastable<YAMLWrite>, TextDOMTransferWriteBase<YAMLWrite>.Interface, IUpCastable<TextDOMTransferWriteBase<YAMLWrite>>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<YAMLWrite>, TextDOMTransferWriteBase<YAMLWrite>.Interface, IUpCastable<TextDOMTransferWriteBase<YAMLWrite>>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TextDOMTransferWriteBase<YAMLWrite> __TextDOMTransferWriteBase;

		unsafe ref YAMLWrite IUpCastable<YAMLWrite>.Cast()
		{
			return ref *(YAMLWrite*)null;
		}

		unsafe ref TextDOMTransferWriteBase<YAMLWrite> IUpCastable<TextDOMTransferWriteBase<YAMLWrite>>.Cast()
		{
			return ref *(TextDOMTransferWriteBase<YAMLWrite>*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
