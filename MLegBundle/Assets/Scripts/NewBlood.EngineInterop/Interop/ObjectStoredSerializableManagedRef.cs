namespace Interop
{
	[SupportsInheritance]
	public struct ObjectStoredSerializableManagedRef : ObjectStoredSerializableManagedRef.Interface, IUpCastable<ObjectStoredSerializableManagedRef>, SerializableManagedRef.Interface, IUpCastable<SerializableManagedRef>
	{
		public interface Interface : IUpCastable<ObjectStoredSerializableManagedRef>, SerializableManagedRef.Interface, IUpCastable<SerializableManagedRef>
		{
		}

		[BaseField]
		private SerializableManagedRef __SerializableManagedRef;

		unsafe ref ObjectStoredSerializableManagedRef IUpCastable<ObjectStoredSerializableManagedRef>.Cast()
		{
			return ref *(ObjectStoredSerializableManagedRef*)null;
		}

		unsafe ref SerializableManagedRef IUpCastable<SerializableManagedRef>.Cast()
		{
			return ref *(SerializableManagedRef*)null;
		}
	}
}
