using Interop.Unity;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct MeshRenderer : MeshRenderer.Interface, IUpCastable<MeshRenderer>, Renderer.Interface, IUpCastable<Renderer>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>, BaseRenderer.Interface, IUpCastable<BaseRenderer>
	{
		public interface Interface : IUpCastable<MeshRenderer>, Renderer.Interface, IUpCastable<Renderer>, Component.Interface, IUpCastable<Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>, BaseRenderer.Interface, IUpCastable<BaseRenderer>
		{
		}

		[BaseField]
		private Renderer __Renderer;

		unsafe ref MeshRenderer IUpCastable<MeshRenderer>.Cast()
		{
			return ref *(MeshRenderer*)null;
		}

		unsafe ref Renderer IUpCastable<Renderer>.Cast()
		{
			return ref *(Renderer*)null;
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

		unsafe ref BaseRenderer IUpCastable<BaseRenderer>.Cast()
		{
			return ref *(BaseRenderer*)null;
		}
	}
}
