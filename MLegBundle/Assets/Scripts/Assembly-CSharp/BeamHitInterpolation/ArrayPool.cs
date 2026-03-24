using System.Collections.Generic;
using UnityEngine;

namespace BeamHitInterpolation
{
	public static class ArrayPool
	{
		private static readonly Queue<RaycastHit[]> RaycastHitPool;

		private const int DefaultRaycastSize = 32;

		private static readonly Queue<Collider[]> ColliderPool;

		private const int DefaultColliderSize = 50;

		public static RaycastHit[] GetRaycastHits()
		{
			return null;
		}

		public static void ReturnRaycastHits(RaycastHit[] array)
		{
		}

		public static Collider[] GetColliders(int minSize = 50)
		{
			return null;
		}

		public static void ReturnColliders(Collider[] array)
		{
		}
	}
}
