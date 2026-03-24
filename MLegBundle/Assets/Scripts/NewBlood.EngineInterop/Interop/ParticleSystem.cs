using Interop.Unity;
using Microsoft.CodeAnalysis;
using Unity.Jobs;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct ParticleSystem : ParticleSystem.Interface, IUpCastable<ParticleSystem>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<ParticleSystem>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Component __Component;

		public InlineArray1<Pointer<ParticleSystemParticles>> m_Particles;

		public unsafe ParticleSystemReadOnlyState* m_ReadOnlyState;

		public unsafe ParticleSystemState* m_State;

		public unsafe ParticleSystemModules* m_Modules;

		public RayBudgetState m_RayBudgetState;

		public int m_RayBudget;

		public int m_EmittersIndex;

		[NativeTypeName("bool")]
		public byte m_NeedsSync;

		public JobHandle m_NeedsSyncFence;

		public JobHandle m_UpdateFence;

		public NativeArrayData m_ManagedJobData;

		unsafe ref ParticleSystem IUpCastable<ParticleSystem>.Cast()
		{
			return ref *(ParticleSystem*)null;
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
