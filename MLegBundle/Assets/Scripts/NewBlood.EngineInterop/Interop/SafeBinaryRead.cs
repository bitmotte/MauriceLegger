namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct SafeBinaryRead : SafeBinaryRead.Interface, IUpCastable<SafeBinaryRead>, TransferBase.Interface, IUpCastable<TransferBase>
	{
		public interface Interface : IUpCastable<SafeBinaryRead>, TransferBase.Interface, IUpCastable<TransferBase>
		{
		}

		[BaseField]
		private TransferBase __TransferBase;

		unsafe ref SafeBinaryRead IUpCastable<SafeBinaryRead>.Cast()
		{
			return ref *(SafeBinaryRead*)null;
		}

		unsafe ref TransferBase IUpCastable<TransferBase>.Cast()
		{
			return ref *(TransferBase*)null;
		}
	}
}
