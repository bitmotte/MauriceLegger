using System;
using System.Runtime.CompilerServices;

namespace ULTRAKILL.Enemy
{
	public struct DifficultyValue<T>
	{
		private Func<GameDifficulty, T> getter;

		private GameDifficulty current;

		public T value;

		public void Set(GameDifficulty difficulty)
		{
		}

		public DifficultyValue(Func<GameDifficulty, T> getter, GameDifficulty difficulty)
		{
			this.getter = null;
			current = default(GameDifficulty);
			value = default(T);
		}
	}
}
