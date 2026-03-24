using Interop.core;

namespace Interop
{
	public struct TriggerEvents
	{
		public InlineArray4<vector<ParticleTriggerEvent>> events;

		public dynamic_bitset insideFlags;
	}
}
