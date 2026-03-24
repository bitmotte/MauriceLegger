namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct AudioPlayableOutput : AudioPlayableOutput.Interface, IUpCastable<AudioPlayableOutput>, PlayableOutput.Interface, IUpCastable<PlayableOutput>, ListElement.Interface, IUpCastable<ListElement>
	{
		public interface Interface : IUpCastable<AudioPlayableOutput>, PlayableOutput.Interface, IUpCastable<PlayableOutput>, ListElement.Interface, IUpCastable<ListElement>
		{
		}

		[BaseField]
		private PlayableOutput __PlayableOutput;

		unsafe ref AudioPlayableOutput IUpCastable<AudioPlayableOutput>.Cast()
		{
			return ref *(AudioPlayableOutput*)null;
		}

		unsafe ref PlayableOutput IUpCastable<PlayableOutput>.Cast()
		{
			return ref *(PlayableOutput*)null;
		}

		unsafe ref ListElement IUpCastable<ListElement>.Cast()
		{
			return ref *(ListElement*)null;
		}
	}
}
