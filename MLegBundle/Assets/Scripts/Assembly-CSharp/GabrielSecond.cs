using UnityEngine;

public class GabrielSecond : EnemyScript, IHitTargetCallback
{
	[HideInInspector]
	public GabrielBase gabe;

	private bool valuesSet;

	[Header("Swords")]
	public Transform rightHand;

	public Transform leftHand;

	private TrailRenderer rightHandTrail;

	private TrailRenderer leftHandTrail;

	[SerializeField]
	private SwingCheck2 generalSwingCheck;

	private SwingCheck2 rightSwingCheck;

	private SwingCheck2 leftSwingCheck;

	private MeshRenderer rightHandGlow;

	private MeshRenderer leftHandGlow;

	[SerializeField]
	private AudioSource swingSound;

	[SerializeField]
	private AudioSource kickSwingSound;

	[SerializeField]
	private Renderer[] swordRenderers;

	[SerializeField]
	private GameObject fakeCombinedSwords;

	[SerializeField]
	private Projectile combinedSwordsThrown;

	[HideInInspector]
	public bool swordsCombined;

	[HideInInspector]
	public bool lightSwords;

	[Space(20f)]
	public TrailRenderer kickTrail;

	private float[] moveChanceBonuses;

	private int previousMove;

	public bool ceilingHitChallenge;

	[SerializeField]
	private GameObject ceilingHitEffect;

	private float ceilingHitCooldown;

	private EnemyTarget target => null;

	private EnemyIdentifier eid => null;

	private Animator anim => null;

	private void Awake()
	{
	}

	private void SetValues()
	{
	}

	private void OnDisable()
	{
	}

	public void ChooseAttack()
	{
	}

	private void BasicCombo()
	{
	}

	private void FastComboDash()
	{
	}

	public void FastCombo()
	{
	}

	private void ThrowCombo()
	{
	}

	private void CombineSwords()
	{
	}

	private void Gattai()
	{
	}

	private void CombinedSwordAttack()
	{
	}

	public void UnGattai(bool destroySwords = true)
	{
	}

	private void CheckIfSwordsCombined()
	{
	}

	private void CreateLightSwords()
	{
	}

	private void ThrowSwords()
	{
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

	public void DamageStartKick(int damage)
	{
	}

	public void DamageStopKick(int keepMoving)
	{
	}

	private void DamageStopped(int keepMoving)
	{
	}

	public void DamageStartBoth(int damage)
	{
	}

	public void DamageStopBoth(int keepMoving)
	{
	}

	private void SetDamage(int damage)
	{
	}

	public void TargetBeenHit()
	{
	}

	public void CeilingCheck(Rigidbody rb, Enemy mach, GabrielVoice voice)
	{
	}
}
