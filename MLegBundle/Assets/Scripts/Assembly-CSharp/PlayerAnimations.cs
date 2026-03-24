using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PlayerAnimations : MonoSingleton<PlayerAnimations>
{
	private Animator anim;

	private NewMovement nm;

	private GroundCheckGroup gc;

	private float directionLerp;

	[SerializeField]
	private Transform chest;

	[SerializeField]
	private Transform head;

	[SerializeField]
	private Transform rightArm;

	[SerializeField]
	private Transform leftArm;

	private float aimerWeight;

	private float aimerWeightSpeed;

	private float leftArmWeight;

	[SerializeField]
	private GameObject[] weapons;

	[SerializeField]
	private GameObject[] altweapons;

	private bool bigWeapon;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void AimRightArm(Transform aimer)
	{
	}

	public void Jump()
	{
	}

	public void Land(float force)
	{
	}

	public void Shoot(float speed = 1f)
	{
	}

	public void Punch(float speed = 1f)
	{
	}

	public void CoinToss()
	{
	}

	public void UpdateWeapon(GameObject _)
	{
	}

	public void UpdateWeapon()
	{
	}
}
