using UnityEngine;

public class Gabriel : EnemyScript
{
	[HideInInspector]
	public GabrielBase gabe;

	private bool valuesSet;

	public Transform rightHand;

	public Transform leftHand;

	private GameObject rightHandWeapon;

	private GameObject leftHandWeapon;

	private WeaponTrail rightHandTrail;

	private WeaponTrail leftHandTrail;

	private SwingCheck2 rightSwingCheck;

	private SwingCheck2 leftSwingCheck;

	public GameObject sword;

	public GameObject zweiHander;

	public GameObject axe;

	public GameObject spear;

	public GameObject glaive;

	private int spearAttacks;

	private int throws;

	private GameObject thrownObject;

	private bool threwAxes;

	private float[] moveChanceBonuses;

	private int previousMove;

	private EnemyIdentifier eid => null;

	private EnemyTarget target => null;

	private int difficulty => 0;

	private Animator anim => null;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void ChooseAttack()
	{
	}

	private void StingerCombo()
	{
	}

	private void SpearCombo()
	{
	}

	private void ZweiDash()
	{
	}

	public void ZweiCombo()
	{
	}

	private void AxeThrow()
	{
	}

	private void SpearAttack()
	{
	}

	private void SpearFlash()
	{
	}

	private void SpearGoHorizontal()
	{
	}

	private void SpearGo()
	{
	}

	private void SpearThrow()
	{
	}

	private void ThrowWeapon(GameObject projectile)
	{
	}

	private void DestroyWeapon(GameObject weapon, WeaponTrail trail, SwingCheck2 swingCheck)
	{
	}

	private void CheckForThrown()
	{
	}

	public void EnableWeapon()
	{
	}

	public void DisableWeapon()
	{
	}

	private void SpawnLeftHandWeapon(GabrielWeaponType weapon)
	{
	}

	private void SpawnRightHandWeapon(GabrielWeaponType weapon)
	{
	}

	private GameObject GetWeaponGameObject(GabrielWeaponType weapon)
	{
		return null;
	}

	private SwingCheck2 WeaponHitBox(GabrielWeaponType weapon)
	{
		return null;
	}

	private SwingCheck2 CreateHitBox(Vector3 position, Vector3 size, bool ignoreSlide = false)
	{
		return null;
	}

	public void DamageStartLeft(int damage)
	{
	}

	public void DamageStopLeft(int keepMoving)
	{
	}

	public void DamageStartRight(int damage)
	{
	}

	public void DamageStopRight(int keepMoving)
	{
	}

	private void ResetAnimSpeed()
	{
	}
}
