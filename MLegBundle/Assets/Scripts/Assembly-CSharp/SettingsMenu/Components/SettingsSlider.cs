using UnityEngine;
using UnityEngine.UI;
using plog;

namespace SettingsMenu.Components
{
	public class SettingsSlider : SettingsBuilderBase
	{
		private static readonly plog.Logger Log;

		[SerializeField]
		private Button containerButton;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private SliderValueToText sliderValueToText;

		private void Awake()
		{
		}

		private void OnContainerButtonClicked()
		{
		}

		public override void ConfigureFrom(SettingsItemBuilder itemBuilder, SettingsPageBuilder pageBuilder)
		{
		}

		public void SelectInnerSlider()
		{
		}

		public override void SetSelected()
		{
		}

		public override void AttachRestoreDefaultButton(SettingsRestoreDefaultButton restoreDefaultButton)
		{
		}
	}
}
