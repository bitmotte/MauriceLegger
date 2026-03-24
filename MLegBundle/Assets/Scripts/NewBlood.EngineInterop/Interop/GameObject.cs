using System;
using Interop.Unity;
using Interop.core;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct GameObject : GameObject.Interface, IUpCastable<GameObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		[Flags]
		public enum ActivationState
		{
			kNotActivating = 0,
			kActivatingChildren = 1,
			kActivatingComponents = 2,
			kDeactivatingChildren = 4,
			kDeactivatingComponents = 8,
			kDestroying = 0x10,
			kActivatingOrDeactivating = 0xF
		}

		public struct ComponentPair
		{
			public uint typeIndex;

			public ImmediatePtr<Component> component;
		}

		public enum Bits
		{
			kNumBitsForEditorVisibility = 2,
			kNumBitsForPrefabInstanceHiddenForInContextEditing = 1
		}

		public interface Interface : IUpCastable<GameObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private EditorExtension __EditorExtension;

		public vector<ComponentPair> m_Component;

		public uint m_Layer;

		public ushort m_Tag;

		[NativeTypeName("bool")]
		public byte m_IsActive;

		public sbyte m_IsActiveCached;

		public ActivationState m_ActivationState;

		public uint m_SupportedMessages;

		public ConstantString m_Name;

		public ListNode<GameObject> m_ActiveGONode;

		private const byte EditorVisibilityBitOffset = 0;

		private const byte PrefabInstanceHiddenForInContextEditingBitOffset = 2;

		unsafe ref GameObject IUpCastable<GameObject>.Cast()
		{
			return ref *(GameObject*)null;
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
