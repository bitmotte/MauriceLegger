using Interop.Unity;
using Microsoft.CodeAnalysis;
using UnityEngine;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct Object : Object.Interface, IUpCastable<Object>
	{
		public enum Bits
		{
			kMemLabelBits = 12,
			kTemporaryFlagsBits = 1,
			kHideFlagsBits = 7,
			kIsPersistentBits = 1,
			kCachedTypeIndexBits = 11
		}

		public struct Vtbl<T> where T : unmanaged, Interface
		{
			public unsafe delegate* unmanaged[Thiscall]<T*, int, void> __deleting_dtor;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> MainThreadCleanup;

			public unsafe delegate* unmanaged[Thiscall]<T*, AwakeFromLoadMode, void> AwakeFromLoad;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> AwakeFromLoadThreaded;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> CheckConsistency;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> Reset;

			public unsafe delegate* unmanaged[Thiscall]<T*, void> SmartReset;

			[NativeTypeName("bool ()")]
			public unsafe delegate* unmanaged[Thiscall]<T*, byte> IsAScriptedObject;

			[NativeTypeName("Unity::Type const *() const")]
			public unsafe delegate* unmanaged[Thiscall]<T*, Type*> GetTypeVirtualInternal;

			[NativeTypeName("char const *() const")]
			public unsafe delegate* unmanaged[Thiscall]<T*, sbyte*> GetName;

			[NativeTypeName("void (char const *)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, sbyte*, void> SetName;

			public unsafe delegate* unmanaged[Thiscall]<T*, HideFlags, void> SetHideFlags;

			public unsafe delegate* unmanaged[Thiscall]<T*, nuint> GetRuntimeMemorySize;

			public unsafe delegate* unmanaged[Thiscall]<T*, ScriptingObjectPtr, void> SetCachedScriptingObject;

			[NativeTypeName("bool ()")]
			public unsafe delegate* unmanaged[Thiscall]<T*, byte> GetNeedsPerObjectTypeTree;

			[NativeTypeName("void (SafeBinaryRead &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, SafeBinaryRead*, void> VirtualRedirectTransfer_SafeBinaryRead;

			[NativeTypeName("void (GenerateTypeTreeTransfer &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, GenerateTypeTreeTransfer*, void> VirtualRedirectTransfer_GenerateTypeTreeTransfer;

			[NativeTypeName("void (RemapPPtrTransfer &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, RemapPPtrTransfer*, void> VirtualRedirectTransfer_RemapPPtrTransfer;

			[NativeTypeName("void (StreamedBinaryRead &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, StreamedBinaryRead*, void> VirtualRedirectTransfer_StreamedBinaryRead;

			[NativeTypeName("void (StreamedBinaryWrite &)")]
			public unsafe delegate* unmanaged[Thiscall]<T*, StreamedBinaryWrite*, void> VirtualRedirectTransfer_StreamedBinaryWrite;
		}

		public interface Interface : IUpCastable<Object>
		{
		}

		public unsafe void** __vftable;

		public int m_InstanceID;

		public uint __bits;

		public unsafe EventEntry* m_EventIndex;

		public ScriptingGCHandle m_MonoReference;

		private const byte MemLabelBitOffset = 0;

		private const byte TemporaryFlagsBitOffset = 12;

		private const byte HideFlagsBitOffset = 13;

		private const byte IsPersistentBitOffset = 20;

		private const byte CachedTypeIndexBitOffset = 21;

		public uint m_MemLabelIdentifier
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint m_TemporaryFlags
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint m_HideFlags
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint m_IsPersistent
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint m_CachedTypeIndex
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
