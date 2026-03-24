using UnityEngine;

namespace Interop
{
	public struct ParticleSystemEmissionState
	{
		public float m_ParticleSpacing;

		public float m_ToEmitAccumulator;

		public float m_BurstEmitSubFrame;

		[NativeTypeName("Rand")]
		public Random.State m_Random;
	}
}
