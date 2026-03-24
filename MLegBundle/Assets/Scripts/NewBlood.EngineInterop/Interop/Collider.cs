using Interop.Unity;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct Collider : Collider.Interface, IUpCastable<Collider>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<Collider>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Component __Component;

		[NativeTypeName("PhysicsScene *")]
		public unsafe void* m_PhysicsScene;

		public PPtr<PhysicsMaterial> m_Material;

		[NativeTypeName("physx::PxShape *")]
		public unsafe void* m_Shape;

		public vector_set<Pointer<Collider>> m_IgnoredColliders;

		public float m_ContactOffset;

		[NativeTypeName("bool")]
		public byte m_IsTrigger;

		[NativeTypeName("bool")]
		public byte m_Enabled;

		[NativeTypeName("bool")]
		public byte m_IsListeningTransform;

		[NativeTypeName("bool")]
		public byte m_HasModifiableContacts;

		[NativeTypeName("bool")]
		public byte m_ProvidesContacts;

		public int m_LayerOverridePriority;

		public BitField m_IncludeLayers;

		public BitField m_ExcludeLayers;

		unsafe ref Collider IUpCastable<Collider>.Cast()
		{
			return ref *(Collider*)null;
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
	}
}
