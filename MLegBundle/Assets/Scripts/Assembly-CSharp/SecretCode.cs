using UnityEngine;

public class SecretCode : MonoBehaviour
{
	public string code;

	public bool revertEventOnFailure;

	public int startingPoint;

	[HideInInspector]
	public int currentPoint;

	public UltrakillEvent onSuccess;

	private void Start()
	{
	}

	public void Input(string entry)
	{
	}

	public void Input(char entry)
	{
	}

	public void Reset()
	{
	}
}
