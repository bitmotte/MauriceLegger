using UnityEngine;

namespace Interop
{
	public struct MinMaxAABB
	{
		[NativeTypeName("Vector3f")]
		public Vector3 m_Min;

		[NativeTypeName("Vector3f")]
		public Vector3 m_Max;
	}
}
