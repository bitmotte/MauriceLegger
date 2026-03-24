using System.Collections.Generic;

namespace BeamHitInterpolation
{
	public static class ListPool<T>
	{
		private static readonly Stack<List<T>> Pool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> list)
		{
		}
	}
}
