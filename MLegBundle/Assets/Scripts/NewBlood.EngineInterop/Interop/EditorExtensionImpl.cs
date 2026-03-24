using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct EditorExtensionImpl : EditorExtensionImpl.Interface, IUpCastable<EditorExtensionImpl>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<EditorExtensionImpl>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Object __Object;

		unsafe ref EditorExtensionImpl IUpCastable<EditorExtensionImpl>.Cast()
		{
			return ref *(EditorExtensionImpl*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
