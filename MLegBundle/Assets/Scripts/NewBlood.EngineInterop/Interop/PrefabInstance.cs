using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct PrefabInstance : PrefabInstance.Interface, IUpCastable<PrefabInstance>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<PrefabInstance>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Object __Object;

		unsafe ref PrefabInstance IUpCastable<PrefabInstance>.Cast()
		{
			return ref *(PrefabInstance*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
