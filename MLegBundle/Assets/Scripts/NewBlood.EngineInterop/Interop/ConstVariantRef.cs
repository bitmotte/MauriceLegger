using Interop.Unity;

namespace Interop
{
	public struct ConstVariantRef
	{
		[NativeTypeName("Unity::Type const *")]
		public unsafe Type* m_Type;

		public unsafe void* m_Data;
	}
}
