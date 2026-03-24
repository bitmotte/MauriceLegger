using UnityEngine;

public class CopyLineRenderer : MonoBehaviour
{
	[HideInInspector]
	public LineRenderer toCopy;

	[HideInInspector]
	public LineRenderer lr;

	private float origWidth;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
