using Interop.TextRenderingPrivate;
using Microsoft.CodeAnalysis;

namespace Interop.TextRendering
{
	[NonCopyable]
	[SupportsInheritance]
	public struct Font : Font.Interface, IUpCastable<Font>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<Font>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private NamedObject __NamedObject;

		public float m_LineSpacing;

		public int m_FontSize;

		public PPtr<Material> m_DefaultMaterial;

		public PPtr<Texture> m_Texture;

		public unsafe FontImpl* m_FontImpl;

		unsafe ref Font IUpCastable<Font>.Cast()
		{
			return ref *(Font*)null;
		}

		unsafe ref NamedObject IUpCastable<NamedObject>.Cast()
		{
			return ref *(NamedObject*)null;
		}

		unsafe ref EditorExtension IUpCastable<EditorExtension>.Cast()
		{
			return ref *(EditorExtension*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
