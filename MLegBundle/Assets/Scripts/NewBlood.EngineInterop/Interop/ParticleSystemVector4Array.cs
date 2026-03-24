using Interop.core;

namespace Interop
{
	public struct ParticleSystemVector4Array
	{
		[NativeTypeName("ParticleSystemFloatArray[4]")]
		public InlineArray4<vector<float>> vec;
	}
}
