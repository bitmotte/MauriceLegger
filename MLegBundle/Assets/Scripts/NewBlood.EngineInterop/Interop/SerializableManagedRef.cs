using Interop.std;

namespace Interop
{
	[SupportsInheritance]
	public struct SerializableManagedRef : SerializableManagedRef.Interface, IUpCastable<SerializableManagedRef>
	{
		public interface Interface : IUpCastable<SerializableManagedRef>
		{
		}

		public unsafe void** __vftable;

		public PPtr<MonoScript> m_Script;

		public shared_ptr<MonoScriptCache> m_ScriptCache;

		public unsafe ManagedReferencesRegistry* m_ManagedReferencesRegistry;

		unsafe ref SerializableManagedRef IUpCastable<SerializableManagedRef>.Cast()
		{
			return ref *(SerializableManagedRef*)null;
		}
	}
}
