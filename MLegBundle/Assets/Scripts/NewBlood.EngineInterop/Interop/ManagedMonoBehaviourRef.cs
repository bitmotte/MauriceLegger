namespace Interop
{
	[SupportsInheritance]
	public struct ManagedMonoBehaviourRef : ManagedMonoBehaviourRef.Interface, IUpCastable<ManagedMonoBehaviourRef>, ObjectStoredSerializableManagedRef.Interface, IUpCastable<ObjectStoredSerializableManagedRef>, SerializableManagedRef.Interface, IUpCastable<SerializableManagedRef>
	{
		public interface Interface : IUpCastable<ManagedMonoBehaviourRef>, ObjectStoredSerializableManagedRef.Interface, IUpCastable<ObjectStoredSerializableManagedRef>, SerializableManagedRef.Interface, IUpCastable<SerializableManagedRef>
		{
		}

		[BaseField]
		private ObjectStoredSerializableManagedRef __ObjectStoredSerializableManagedRef;

		[NativeTypeName("ScriptingMethodPtr const *")]
		public unsafe ScriptingMethodPtr* m_CachedMethods;

		unsafe ref ManagedMonoBehaviourRef IUpCastable<ManagedMonoBehaviourRef>.Cast()
		{
			return ref *(ManagedMonoBehaviourRef*)null;
		}

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
