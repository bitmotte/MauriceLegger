using System;
using ULTRAKILL.Portal;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace ULTRAKILL.Enemy
{
	public class Vision : IDisposable
	{
		public VisionTypeFilter filter;

		public JobHandle handle;

		public NativeList<TargetIndexAndDistance> targetsArray;

		public NativeArray<int> startIndices;

		public NativeArray<int> counts;

		public int visionIndex;

		public Vector3 sourcePos;

		public float maxDistance;

		public Vision(Vector3 sourcePos, VisionTypeFilter typeFilter)
		{
		}

		public void UpdateFilter(VisionTypeFilter filter)
		{
		}

		public void UpdateSourcePos(Vector3 sourcePos)
		{
		}

		public static bool ValidateEIDTarget(TargetData data, EnemyTarget eidTarget)
		{
			return false;
		}

		private bool IsVisibleToLastPortal(ref PortalHandleSequence sequence, PortalScene scene, Vector3 sourcePos)
		{
			return false;
		}

		public bool TrySee(VisionQuery query, out TargetDataRef data)
		{
			data = default(TargetDataRef);
			return false;
		}

		public TargetDataRef GetDataRef(TargetHandle target)
		{
			return default(TargetDataRef);
		}

		public TargetData CalculateData(TargetHandle target)
		{
			return default(TargetData);
		}

		public void Dispose()
		{
		}
	}
}
