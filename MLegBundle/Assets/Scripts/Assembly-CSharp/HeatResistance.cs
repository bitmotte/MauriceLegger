using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class HeatResistance : MonoSingleton<HeatResistance>
{
	[SerializeField]
	private Slider meter;

	[SerializeField]
	private TMP_Text meterLabel;

	[SerializeField]
	private TMP_Text meterPercentage;

	[SerializeField]
	private Image greenFlash;

	[SerializeField]
	private GameObject hurtingSound;

	[SerializeField]
	private Image screenShatter;

	[SerializeField]
	private CanvasGroup heatResistanceGroup;

	[SerializeField]
	private CanvasGroup heatFixedGroup;

	public float speed;

	private float difficultySpeedModifier;

	private float heatResistance;

	private TimeSince hurtTimer;

	private bool recharging;

	private float rechargeSpeed;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void RechargeOnce()
	{
	}

	public void SetRechargeMode(float targetSpeedMultiplier)
	{
	}
}
