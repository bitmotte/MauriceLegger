using Interop.core;
using Interop.math;
using UnityEngine;

namespace Interop
{
	public struct AnimationCurveTpl<T> where T : unmanaged
	{
		public struct Cache
		{
			public int index;

			public float time;

			public float timeEnd;

			[NativeTypeName("Quaternionf[4]")]
			public InlineArray4<Quaternion> coeff;
		}

		public Cache m_Cache;

		public Cache m_ClampCache;

		public vector<KeyframeTpl<T>> m_Curve;

		public InternalWrapMode m_PreInfinity;

		public InternalWrapMode m_PostInfinity;

		public RotationOrder m_RotationOrder;
	}
}
