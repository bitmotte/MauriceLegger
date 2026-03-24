namespace Interop
{
	[IncompleteType]
	[SupportsInheritance]
	public struct PlayableOutput : PlayableOutput.Interface, IUpCastable<PlayableOutput>, ListElement.Interface, IUpCastable<ListElement>
	{
		public interface Interface : IUpCastable<PlayableOutput>, ListElement.Interface, IUpCastable<ListElement>
		{
		}

		[BaseField]
		private ListElement __ListElement;

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
