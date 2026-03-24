using UnityEngine;

namespace Interop.math
{
	public struct trsX
	{
		[NativeTypeName("math::_float3")]
		public Vector4 t;

		[NativeTypeName("math::_float4")]
		public Vector4 q;

		[NativeTypeName("math::_float3")]
		public Vector4 s;
	}
}
