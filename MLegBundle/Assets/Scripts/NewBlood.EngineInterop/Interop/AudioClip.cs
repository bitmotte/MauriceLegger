using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct AudioClip : AudioClip.Interface, IUpCastable<AudioClip>, SampleClip.Interface, IUpCastable<SampleClip>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<AudioClip>, SampleClip.Interface, IUpCastable<SampleClip>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private SampleClip __SampleClip;

		unsafe ref AudioClip IUpCastable<AudioClip>.Cast()
		{
			return ref *(AudioClip*)null;
		}

		unsafe ref SampleClip IUpCastable<SampleClip>.Cast()
		{
			return ref *(SampleClip*)null;
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
