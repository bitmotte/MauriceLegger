using Interop.core;
using Microsoft.CodeAnalysis;
using UnityEngine;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct Flare : Flare.Interface, IUpCastable<Flare>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public struct FlareElement
		{
			public uint m_ImageIndex;

			public float m_Position;

			public float m_Size;

			[NativeTypeName("ColorRGBAf")]
			public Color m_Color;

			[NativeTypeName("bool")]
			public byte m_UseLightColor;

			[NativeTypeName("bool")]
			public byte m_Rotate;

			[NativeTypeName("bool")]
			public byte m_Zoom;

			[NativeTypeName("bool")]
			public byte m_Fade;
		}

		public interface Interface : IUpCastable<Flare>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private NamedObject __NamedObject;

		public vector<FlareElement> m_Elements;

		public PPtr<Texture> m_FlareTexture;

		public int m_TextureLayout;

		[NativeTypeName("bool")]
		public byte m_UseFog;

		unsafe ref Flare IUpCastable<Flare>.Cast()
		{
			return ref *(Flare*)null;
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
