using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct GlobalGameManager : GlobalGameManager.Interface, IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
	{
		public interface Interface : IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private GameManager __GameManager;

		unsafe ref GlobalGameManager IUpCastable<GlobalGameManager>.Cast()
		{
			return ref *(GlobalGameManager*)null;
		}

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
