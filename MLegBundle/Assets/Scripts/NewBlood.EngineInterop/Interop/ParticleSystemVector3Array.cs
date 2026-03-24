using Interop.core;

namespace Interop
{
	public struct ParticleSystemVector3Array
	{
		[NativeTypeName("ParticleSystemFloatArray[3]")]
		public InlineArray3<vector<float>> vec;
	}
}
