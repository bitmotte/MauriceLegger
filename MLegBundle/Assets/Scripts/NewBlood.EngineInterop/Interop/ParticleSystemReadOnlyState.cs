namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct ParticleSystemReadOnlyState : ParticleSystemReadOnlyState.Interface, IUpCastable<ParticleSystemReadOnlyState>, IParticleSystemProperties.Interface, IUpCastable<IParticleSystemProperties>
	{
		public interface Interface : IUpCastable<ParticleSystemReadOnlyState>, IParticleSystemProperties.Interface, IUpCastable<IParticleSystemProperties>
		{
		}

		[BaseField]
		private IParticleSystemProperties __IParticleSystemProperties;

		unsafe ref ParticleSystemReadOnlyState IUpCastable<ParticleSystemReadOnlyState>.Cast()
		{
			return ref *(ParticleSystemReadOnlyState*)null;
		}

		unsafe ref IParticleSystemProperties IUpCastable<IParticleSystemProperties>.Cast()
		{
			return ref *(IParticleSystemProperties*)null;
		}
	}
}
