using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct MonoScript : MonoScript.Interface, IUpCastable<MonoScript>, TextAsset.Interface, IUpCastable<TextAsset>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<MonoScript>, TextAsset.Interface, IUpCastable<TextAsset>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private TextAsset __TextAsset;

		unsafe ref MonoScript IUpCastable<MonoScript>.Cast()
		{
			return ref *(MonoScript*)null;
		}

		unsafe ref TextAsset IUpCastable<TextAsset>.Cast()
		{
			return ref *(TextAsset*)null;
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
