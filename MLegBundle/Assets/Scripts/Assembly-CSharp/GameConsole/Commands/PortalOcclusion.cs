using plog;

namespace GameConsole.Commands
{
	public class PortalOcclusion : ICommand, IConsoleLogger
	{
		public Logger Log { get; }

		public string Name => null;

		public string Description => null;

		public string Command => null;

		public void Execute(Console con, string[] args)
		{
		}

		private static bool TryParseBool(string s, out bool value)
		{
			value = default(bool);
			return false;
		}
	}
}
