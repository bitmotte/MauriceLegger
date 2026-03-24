using Interop.std;

namespace Interop.TextRenderingPrivate
{
	public struct DynamicFontData
	{
		public map<FontRef, Pointer<FT_FaceRec>> m_Faces;

		public unsafe Destroyable* m_Data;
	}
}
