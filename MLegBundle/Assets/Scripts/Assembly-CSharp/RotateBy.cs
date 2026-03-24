using UnityEngine;

public class RotateBy : MonoBehaviour
{
	public Vector3 rotation;

	public float speed;

	[HideInInspector]
	public bool gotValues;

	[HideInInspector]
	public Vector3 targetRotation;

	[HideInInspector]
	public bool rotating;

	[HideInInspector]
	public float rotationLeft;

	[HideInInspector]
	public Vector3 originalRotation;

	[HideInInspector]
	public AudioSource aud;

	[HideInInspector]
	public float origPitch;

	public AudioClip rotateSound;

	public AudioClip stopSound;

	public Transform[] setToTarget;

	public UltrakillEvent onDoneRotating;

	private void Start()
	{
	}

	private void GetValues()
	{
	}

	private void Update()
	{
	}

	private void Tick(float time)
	{
	}

	public void AddRotation()
	{
	}

	public void AddRotationCustom(float degrees)
	{
	}

	public void AddRotationCustom(Vector3 customRotation)
	{
	}

	private void Rotate(Vector3 rotation)
	{
	}

	private void PlaySound(AudioClip sound, bool loop)
	{
	}

	public void ResetRotation(bool instant)
	{
	}

	public void Skip()
	{
	}
}
