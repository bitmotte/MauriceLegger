using Interop.Unity;
using Interop.core;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct MonoBehaviour : MonoBehaviour.Interface, IUpCastable<MonoBehaviour>, Behaviour.Interface, IUpCastable<Behaviour>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>, IManagedObjectHost.Interface, IUpCastable<IManagedObjectHost>
	{
		public interface Interface : IUpCastable<MonoBehaviour>, Behaviour.Interface, IUpCastable<Behaviour>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>, IManagedObjectHost.Interface, IUpCastable<IManagedObjectHost>
		{
		}

		[BaseField]
		private Behaviour __Behaviour;

		[BaseField]
		private IManagedObjectHost __IManagedObjectHost;

		public basic_string m_Name;

		public List<Coroutine> m_ActiveCoroutines;

		public ListNode<Behaviour> m_UpdateNode;

		public ListNode<Behaviour> m_FixedUpdateNode;

		public ListNode<Behaviour> m_LateUpdateNode;

		public ListNode<MonoBehaviour> m_GUINode;

		public ManagedMonoBehaviourRef m_ScriptedObject;

		public ListNode<MonoBehaviour> m_OnRenderObjectNode;

		public unsafe ObjectGUIState* m_GUIState;

		public int m_GUIDisplayMask;

		[NativeTypeName("bool")]
		public byte m_DidAwake;

		[NativeTypeName("bool")]
		public byte m_DidStart;

		[NativeTypeName("bool")]
		public byte m_UseGUILayout;

		[NativeTypeName("bool")]
		public byte m_IsDestroying;

		[NativeTypeName("bool")]
		public byte m_AddedToManager;

		public unsafe AudioCustomFilter* m_AudioCustomFilter;

		[NativeTypeName("bool")]
		public byte m_HasActiveCancellationToken;

		unsafe ref MonoBehaviour IUpCastable<MonoBehaviour>.Cast()
		{
			return ref *(MonoBehaviour*)null;
		}

		unsafe ref Behaviour IUpCastable<Behaviour>.Cast()
		{
			return ref *(Behaviour*)null;
		}

		unsafe ref Component IUpCastable<Component>.Cast()
		{
			return ref *(Component*)null;
		}

		unsafe ref EditorExtension IUpCastable<EditorExtension>.Cast()
		{
			return ref *(EditorExtension*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}

		unsafe ref IManagedObjectHost IUpCastable<IManagedObjectHost>.Cast()
		{
			return ref *(IManagedObjectHost*)null;
		}
	}
}
