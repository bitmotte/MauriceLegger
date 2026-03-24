using ScriptableObjects;
using UnityEngine;

public class PowerIntro : MonoBehaviour
{
	[SerializeField]
	private PowerPersistentData persistentData;

	[SerializeField]
	private AudioClip introOverride;

	public float introAudioDelay;

	[SerializeField]
	private Animator animator;

	public float animationSpeedMultiplier;

	private void Start()
	{
	}

	private void Activate()
	{
	}
}
