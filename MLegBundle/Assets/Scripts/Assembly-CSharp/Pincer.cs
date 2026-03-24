using UnityEngine;

public class Pincer : MonoBehaviour
{
	[HideInInspector]
	public bool hasValues;

	public Vector3 direction;

	public bool randomInvertDirection;

	public float rotationSpeed;

	public float pincerSpeed;

	public float windup;

	public float delay;

	[HideInInspector]
	public float windupMax;

	[HideInInspector]
	public AudioSource aud;

	[HideInInspector]
	public float origVolume;

	[SerializeField]
	private SpriteRenderer insignia;

	private Vector3 originalScale;

	[SerializeField]
	private SpriteRenderer flash;

	[SerializeField]
	private ParticleSystem flashParticle;

	[SerializeField]
	private Color targetColor;

	[HideInInspector]
	public Color defaultColor;

	[HideInInspector]
	public bool detached;

	[HideInInspector]
	public bool activated;

	[SerializeField]
	private Transform[] beams;

	[HideInInspector]
	public LineRenderer[] lrs;

	[HideInInspector]
	public float[] lrWidths;

	[HideInInspector]
	public bool completed;

	public GameObject firedMessageReceiver;

	public UltrakillEvent onComplete;

	[HideInInspector]
	public int difficulty;

	private TimeSince timeSincePincerStart;

	private TimeSince timeSinceCompletion;

	private void Start()
	{
	}

	private void GetValues()
	{
	}

	private void Update()
	{
	}

	public void Detach()
	{
	}
}
