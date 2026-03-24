using UnityEngine;
using UnityEngine.AI;
using Vertx.Debugging;

namespace Utilities
{
	public static class NavMeshPathExtensions
	{
		public static bool TryGetDistance(this NavMeshPath path, out float distance)
		{
			distance = default(float);
			return false;
		}

		public static float GetDistance(this NavMeshPath path)
		{
			return 0f;
		}

		public static void DrawDebug(this NavMeshPath path, Color color, float duration)
		{
		}

		public static Shape.LineStrip GetLineStrip(this NavMeshPath path)
		{
			return default(Shape.LineStrip);
		}
	}
}
