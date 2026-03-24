namespace Interop
{
	[SupportsInheritance]
	public struct TrackedReferenceBase : TrackedReferenceBase.Interface, IUpCastable<TrackedReferenceBase>
	{
		public interface Interface : IUpCastable<TrackedReferenceBase>
		{
		}

		public ScriptingGCHandle m_MonoObjectReference;

		unsafe ref TrackedReferenceBase IUpCastable<TrackedReferenceBase>.Cast()
		{
			return ref *(TrackedReferenceBase*)null;
		}
	}
}
