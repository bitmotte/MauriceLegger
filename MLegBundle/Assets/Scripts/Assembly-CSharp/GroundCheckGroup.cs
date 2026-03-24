using System.Collections.Generic;
using UnityEngine;

public class GroundCheckGroup : MonoBehaviour
{
	[SerializeField]
	private List<GroundCheck> instances;

	public bool onGround => false;

	public bool touchingGround => false;

	public bool hasImpacted
	{
		set
		{
		}
	}

	public bool heavyFall
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool canJump => false;

	public float sinceLastGrounded => 0f;

	public int forcedOff => 0;

	public float superJumpChance => 0f;

	public float bounceChance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float extraJumpChance => 0f;

	public void AddInstance(GroundCheck instance)
	{
	}

	public void RemoveInstance(GroundCheck instance)
	{
	}

	public void SetLocalPosition(Vector3 pos)
	{
	}

	public void ForceOff()
	{
	}

	public void StopForceOff()
	{
	}

	public void Update()
	{
	}
}
