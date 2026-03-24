using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[IncompleteType]
	[SupportsInheritance]
	public struct Prefab : Prefab.Interface, IUpCastable<Prefab>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<Prefab>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Object __Object;

		unsafe ref Prefab IUpCastable<Prefab>.Cast()
		{
			return ref *(Prefab*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
