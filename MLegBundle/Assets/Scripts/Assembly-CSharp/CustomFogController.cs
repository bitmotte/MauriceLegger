using System;
using UnityEngine;
using UnityEngine.UI;

public class CustomFogController : MonoBehaviour
{
	[Serializable]
	public enum FogState
	{
		Disabled = 0,
		Static = 1,
		Dynamic = 2
	}

	[Serializable]
	private struct ValuePreset
	{
		public FogState fogState;

		public float redAmount;

		public float greenAmount;

		public float blueAmount;

		public float startDistance;

		public float endDistance;

		public ValuePreset(FogState fogState, float redAmount, float greenAmount, float blueAmount, float startDistance, float endDistance)
		{
			this.fogState = default(FogState);
			this.redAmount = 0f;
			this.greenAmount = 0f;
			this.blueAmount = 0f;
			this.startDistance = 0f;
			this.endDistance = 0f;
		}
	}

	[SerializeField]
	private FogState fogState;

	[SerializeField]
	private Button disabledButton;

	private ShopButton disabledShopButton;

	[SerializeField]
	private Button staticButton;

	private ShopButton staticShopButton;

	[SerializeField]
	private Button dynamicButton;

	private ShopButton dynamicShopButton;

	private float redAmount;

	private float greenAmount;

	private float blueAmount;

	[Space]
	[SerializeField]
	private Slider redSlider;

	[SerializeField]
	private Slider greenSlider;

	[SerializeField]
	private Slider blueSlider;

	[Space]
	[SerializeField]
	private Image colorImage;

	private float startDistance;

	private float endDistance;

	[Space]
	[SerializeField]
	private Slider startDistanceSlider;

	[SerializeField]
	private Slider endDistanceSlider;

	[Space]
	[SerializeField]
	private GameObject disabledText;

	[SerializeField]
	private GameObject startDistanceSliderGameObject;

	[SerializeField]
	private GameObject endDistanceSliderGameObject;

	[Space]
	[SerializeField]
	private FogSetterBounds fogSetterBounds;

	private bool levelStarted;

	[Header("Preset Values")]
	[SerializeField]
	private ValuePreset[] presets;

	private bool fogDisabled => false;

	private bool fogStatic => false;

	private bool fogDynamic => false;

	private void Start()
	{
	}

	public void SetState(FogState state)
	{
	}

	public void SetRed(float amount)
	{
	}

	public void SetGreen(float amount)
	{
	}

	public void SetBlue(float amount)
	{
	}

	private void UpdateColor()
	{
	}

	public void SetFogStartDistance(float distance)
	{
	}

	public void SetFogEndDistance(float distance)
	{
	}

	public void ResetValues()
	{
	}

	public void SetPreset(int index)
	{
	}

	public void LevelStart()
	{
	}
}
