using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct EditorExtension : EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Object __Object;

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
