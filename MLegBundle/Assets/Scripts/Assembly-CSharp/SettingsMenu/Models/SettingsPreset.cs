using UnityEngine;
using plog;

namespace SettingsMenu.Models
{
	[CreateAssetMenu(fileName = "SettingsPreset", menuName = "ULTRAKILL/Settings/Preset")]
	public class SettingsPreset : ScriptableObject
	{
		private static readonly plog.Logger Log;

		public PreferenceEntry[] preferences;

		public void Apply()
		{
		}
	}
}
