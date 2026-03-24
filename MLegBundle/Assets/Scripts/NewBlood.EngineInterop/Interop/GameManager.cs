using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct GameManager : GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Object __Object;

		unsafe ref GameManager IUpCastable<GameManager>.Cast()
		{
			return ref *(GameManager*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
