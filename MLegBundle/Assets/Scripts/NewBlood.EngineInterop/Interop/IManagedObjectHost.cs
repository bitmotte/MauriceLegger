namespace Interop
{
	[SupportsInheritance]
	public struct IManagedObjectHost : IManagedObjectHost.Interface, IUpCastable<IManagedObjectHost>
	{
		public interface Interface : IUpCastable<IManagedObjectHost>
		{
		}

		public unsafe void** __vftable;

		unsafe ref IManagedObjectHost IUpCastable<IManagedObjectHost>.Cast()
		{
			return ref *(IManagedObjectHost*)null;
		}
	}
}
