using Interop.TextRendering;
using Interop.core;
using Interop.std;
using UnityEngine;
using Font = Interop.TextRendering.Font;

namespace Interop.TextRenderingPrivate
{
	public struct FontImpl
	{
		public struct CharacterInfo
		{
			public uint index;

			[NativeTypeName("RectT<float>")]
			public Rect uv;

			[NativeTypeName("RectT<float>")]
			public Rect vert;

			public float advance;

			public int size;

			public uint style;

			public float pixelsPerPoint;

			public int lastUsedInFrame;

			[NativeTypeName("bool")]
			public byte flipped;
		}

		[SupportsInheritance]
		public struct KerningCompare : KerningCompare.Interface, IUpCastable<KerningCompare>, function.Interface, IUpCastable<function>
		{
			public interface Interface : IUpCastable<KerningCompare>, function.Interface, IUpCastable<function>
			{
			}

			[BaseField]
			private function __function;

			unsafe ref KerningCompare IUpCastable<KerningCompare>.Cast()
			{
				return ref *(KerningCompare*)null;
			}

			unsafe ref function IUpCastable<function>.Cast()
			{
				return ref *(function*)null;
			}
		}

		public vector_map<Interop.std.pair<ushort, ushort>, float, KerningCompare> m_KerningValues;

		public float m_Tracking;

		public int m_CharacterSpacing;

		public int m_CharacterPadding;

		public int m_AsciiStartOffset;

		[NativeTypeName("bool")]
		public byte m_UseLegacyBoundsCalculation;

		[NativeTypeName("bool")]
		public byte m_ShouldRoundAdvanceValue;

		public int m_ConvertCase;

		public float m_PixelScale;

		public Interop.core.vector<CharacterInfo> m_CharacterRects;

		public vector_set<CharacterInfo> m_UnicodeCharacterRects;
		
		public unsafe Interop.TextRendering.Font* m_OwningFont;

		public Interop.core.vector<sbyte> m_FontData;

		[NativeTypeName("core::vector<core::string_with_label<kMemFontId, char>>")]
		public Interop.core.vector<basic_string> m_FontNames;

		public Interop.core.vector<PPtr<Font>> m_FallbackFonts;

		public Interop.std.vector<RectInt> m_IntRects;

		[NativeTypeName("std::set<TextRenderingPrivate::FontImpl::TexturePosition, std::less<TextRenderingPrivate::FontImpl::TexturePosition>, stl_allocator<TextRenderingPrivate::FontImpl::TexturePosition>>")]
		public set<Vector2Int> m_TexturePositions;

		[NativeTypeName("std::set<TextRenderingPrivate::FontImpl::TexturePosition>::iterator")]
		public set<Vector2Int>.iterator m_TexturePositionsSearchPosition;

		public uint m_TexWidth;

		public uint m_TexHeight;

		public uint m_TexMargin;

		public uint m_SubImageSize;

		public uint m_SubImageIndex;

		public uint m_DefaultStyle;

		public float m_Ascent;

		public float m_Descent;

		public int m_FontRenderingMode;

		public int m_TextureRebuiltCallbackRecursionDepth;

		public unsafe DynamicFontData* m_DynamicData;
	}
}
