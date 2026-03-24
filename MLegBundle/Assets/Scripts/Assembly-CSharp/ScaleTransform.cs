using UnityEngine;
using UnityEngine.Events;

public class ScaleTransform : MonoBehaviour
{
	public bool scaleToOriginalScale;

	public Vector3 target;

	public bool setToZeroOnStart;

	[HideInInspector]
	public bool hasValue;

	public float speed;

	public UnityEvent onComplete;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetTransformX(float target)
	{
	}

	public void SetTransformY(float target)
	{
	}

	public void SetTransformZ(float target)
	{
	}

	public void SetScaleToZero()
	{
	}

	public void SetTargetToZero()
	{
	}
}
