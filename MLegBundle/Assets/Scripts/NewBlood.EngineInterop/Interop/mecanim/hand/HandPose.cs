using Interop.math;

namespace Interop.mecanim.hand
{
	public struct HandPose
	{
		public trsX m_GrabX;

		public unsafe fixed float m_DoFArray[20];

		public float m_Override;

		public float m_CloseOpen;

		public float m_InOut;

		public float m_Grab;
	}
}
