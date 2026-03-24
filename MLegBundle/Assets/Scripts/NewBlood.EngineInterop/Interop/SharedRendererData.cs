using UnityEngine;

namespace Interop
{
	public struct SharedRendererData
	{
		public TransformInfo m_TransformInfo;

		public StaticBatchInfo m_StaticBatchInfo;

		public GlobalLayeringData m_GlobalLayeringData;

		[NativeTypeName("Vector4f[2]")]
		public InlineArray2<Vector4> m_LightmapST;

		public LightmapIndices m_LightmapIndex;

		public uint __bits;

		public uint m_RenderingLayerMask;

		public int m_RendererPriority;
	}
}
