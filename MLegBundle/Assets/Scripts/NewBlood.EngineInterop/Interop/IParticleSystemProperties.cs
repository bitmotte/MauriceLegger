namespace Interop
{
	[SupportsInheritance]
	public struct IParticleSystemProperties : IParticleSystemProperties.Interface, IUpCastable<IParticleSystemProperties>
	{
		public interface Interface : IUpCastable<IParticleSystemProperties>
		{
		}

		public unsafe void** __vftable;

		unsafe ref IParticleSystemProperties IUpCastable<IParticleSystemProperties>.Cast()
		{
			return ref *(IParticleSystemProperties*)null;
		}
	}
}
