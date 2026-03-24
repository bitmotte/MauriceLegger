namespace Interop
{
	[SupportsInheritance]
	public struct ListElement : ListElement.Interface, IUpCastable<ListElement>
	{
		public interface Interface : IUpCastable<ListElement>
		{
		}

		public unsafe ListElement* m_Prev;

		public unsafe ListElement* m_Next;

		unsafe ref ListElement IUpCastable<ListElement>.Cast()
		{
			return ref *(ListElement*)null;
		}
	}
}
