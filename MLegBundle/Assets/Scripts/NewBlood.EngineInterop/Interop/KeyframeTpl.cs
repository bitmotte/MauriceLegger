namespace Interop
{
	public struct KeyframeTpl<T> where T : unmanaged
	{
		public float time;

		public T value;

		public T inSlope;

		public T outSlope;

		public int tangentMode;

		public int weightedMode;

		public T inWeight;

		public T outWeight;
	}
}
