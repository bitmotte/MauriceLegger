namespace Interop.mecanim.animation
{
	public struct DenseClip
	{
		public int m_FrameCount;

		public uint m_CurveCount;

		public float m_SampleRate;

		public float m_BeginTime;

		public uint m_SampleArraySize;

		public OffsetPtr<float> m_SampleArray;
	}
}
