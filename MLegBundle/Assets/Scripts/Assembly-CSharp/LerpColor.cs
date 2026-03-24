using UnityEngine;

public class LerpColor : MonoBehaviour
{
	public bool onEnable;

	public bool oneTime;

	[HideInInspector]
	public bool beenActivated;

	[HideInInspector]
	public bool hasOriginalColor;

	public LerpColorType type;

	private Light lit;

	private Material mat;

	private Water wtr;

	private SpriteRenderer spr;

	private bool activated;

	private bool reverted;

	public bool rainbow;

	private Color originalColor;

	private Color originalTargetColor;

	private Color startColor;

	public Color targetColor;

	private Color currentColor;

	public float time;

	private float currentTime;

	public bool dontOverrideAlpha;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateColor()
	{
	}

	public void Activate()
	{
	}

	public void Revert()
	{
	}

	public void ResetFull()
	{
	}

	public void Skip()
	{
	}

	private void GetValues()
	{
	}

	public static Color RainbowShift(Color color, float amount)
	{
		return default(Color);
	}
}
