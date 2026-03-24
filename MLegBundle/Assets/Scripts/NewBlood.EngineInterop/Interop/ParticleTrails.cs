using Interop.core;
using UnityEngine;

namespace Interop
{
	public struct ParticleTrails
	{
		[NativeTypeName("core::vector<math::float4_storage>")]
		public vector<Vector4> m_Positions;

		public vector<nuint> m_FrontPositions;

		public vector<nuint> m_BackPositions;

		public vector<nuint> m_NumPositions;

		public vector<float> m_TextureOffsets;

		public nuint m_MaxTrails;

		public nuint m_MaxPositionsPerTrail;
	}
}
