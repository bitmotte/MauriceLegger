using Interop.Unity;
using Interop.core;

namespace Interop
{
	public struct AudioCustomFilter
	{
		public struct Instance
		{
			public unsafe Component* m_Owner;

			[NativeTypeName("FMOD::DSP *")]
			public unsafe void* m_DSP;
		}

		public unsafe void** __vftable;

		public vector<Instance> m_Instances;

		public unsafe MonoBehaviour* m_behaviour;
	}
}
