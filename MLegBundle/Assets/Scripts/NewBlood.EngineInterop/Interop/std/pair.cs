namespace Interop.std
{
	public struct pair<T1, T2> where T1 : unmanaged where T2 : unmanaged
	{
		public T1 first;

		public T2 second;
	}
}
