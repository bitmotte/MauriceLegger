namespace Interop
{
	[SupportsInheritance]
	public struct ListNode<T> : ListNode<T>.Interface, IUpCastable<ListNode<T>>, ListElement.Interface, IUpCastable<ListElement> where T : unmanaged
	{
		public interface Interface : IUpCastable<ListNode<T>>, ListElement.Interface, IUpCastable<ListElement>
		{
		}

		[BaseField]
		private ListElement __ListElement;

		public unsafe T* m_Data;

		unsafe ref ListNode<T> IUpCastable<ListNode<T>>.Cast()
		{
			return ref *(ListNode<T>*)null;
		}

		unsafe ref ListElement IUpCastable<ListElement>.Cast()
		{
			return ref *(ListElement*)null;
		}
	}
}
