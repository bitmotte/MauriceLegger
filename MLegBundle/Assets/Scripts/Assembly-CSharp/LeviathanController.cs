using UnityEngine;

public class LeviathanController : EnemyScript
{
	[HideInInspector]
	public bool active;

	public LeviathanHead head;

	[SerializeField]
	private Transform headWeakPoint;

	public LeviathanTail tail;

	[SerializeField]
	private Transform tailWeakPoint;

	[HideInInspector]
	public EnemyIdentifier eid;

	[HideInInspector]
	public Enemy stat;

	public float tailAddHealth;

	public float phaseChangeHealth;

	public bool stopTail;

	private float tailTimer;

	private bool tailAttacking;

	private bool inSubPhase;

	private bool tailAddPhase;

	public bool readyForSecondPhase;

	[HideInInspector]
	public bool secondPhase;

	private int currentAttacks;

	private int setDifficulty;

	public UltrakillEvent onEnterSecondPhase;

	[SerializeField]
	private Transform tailPartsParent;

	[SerializeField]
	private Transform headPartsParent;

	private Transform[] tailParts;

	private Transform[] headParts;

	private int currentPart;

	private GoreZone gz;

	private bool shaking;

	private Vector3 defaultPosition;

	public UltrakillEvent onDeathEnd;

	public GameObject bigSplash;

	[HideInInspector]
	public int difficulty
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void UpdateBuff()
	{
	}

	private int GetDifficulty()
	{
		return 0;
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void BeginMainPhase()
	{
	}

	public void MainPhaseOver()
	{
	}

	public void BeginSubPhase()
	{
	}

	private void SubAttack()
	{
	}

	public void SubAttackOver()
	{
	}

	public void SpecialDeath()
	{
	}

	private void ExplodeTail()
	{
	}

	private void ExplodeHead()
	{
	}

	public void FinalExplosion()
	{
	}

	public void DeathEnd()
	{
	}

	private void GotParried()
	{
	}
}
