using Sandbox;
using ULTRAKILL.Enemy;
using UnityEngine;

public class Idol : MonoBehaviour, IAlter, IAlterOptions<int>
{
	public EnemyIdentifier overrideTarget;

	public bool activeWhileWaitingForOverride;

	[HideInInspector]
	public EnemyIdentifier target;

	private int difficulty;

	[SerializeField]
	private LineRenderer beam;

	[HideInInspector]
	public Material unradiantBeam;

	[SerializeField]
	private Material radiantBeam;

	[SerializeField]
	private SpriteRenderer halo;

	[HideInInspector]
	public Sprite unradiantHalo;

	[HideInInspector]
	public Color haloColor;

	[SerializeField]
	private Sprite radiantHalo;

	private Vector3 beamOffset;

	[SerializeField]
	private GameObject deathParticle;

	private bool dead;

	private EnemyIdentifier eid;

	public Vision vision;

	private VisionQuery beamQuery;

	private VisionQuery nearestQuery;

	private EnemyIdentifier tempTarget;

	private int restorableOverrideTargetID;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<int>[] options => null;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateBuff()
	{
	}

	private void Update()
	{
	}

	private void SlowUpdate()
	{
	}

	public void PickNewTarget(bool ignoreIfAlreadyTargeting = true)
	{
	}

	public void Death()
	{
	}

	private void ChangeTarget(EnemyIdentifier newTarget)
	{
	}

	public void ChangeOverrideTarget(EnemyIdentifier eid)
	{
	}
}
