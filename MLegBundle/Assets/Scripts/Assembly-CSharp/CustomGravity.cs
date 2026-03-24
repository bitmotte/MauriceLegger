using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public sealed class CustomGravity : MonoBehaviour
{
	private Rigidbody _rigidbody;

	[SerializeField]
	private Vector3 _gravity;

	[SerializeField]
	private bool _useOriginalDownAsGravity;

	[SerializeField]
	private bool _useGravity;

	public Vector3 gravity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool useGravity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Reset()
	{
	}
}
