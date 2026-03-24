namespace Interop
{
	public struct EventEntry
	{
		public unsafe void* userData;

		public unsafe EventEntry* next;

		public unsafe delegate* unmanaged[Stdcall]<void*, void*, int, void> callback;

		public AtomicRefCounter refCounter;
	}
}
