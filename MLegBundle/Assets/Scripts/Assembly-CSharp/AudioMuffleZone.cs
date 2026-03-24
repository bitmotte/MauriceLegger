using System.Collections.Generic;
using UnityEngine;

public class AudioMuffleZone : MonoBehaviour
{
	public List<AudioLowPassFilter> muffleTargets;

	private List<float> muffleGoals;

	private bool muffleSounds;

	private float currentMuffle;

	public float speedMultiplier;

	public bool inverse;

	private int requests;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public void AddRequest()
	{
	}

	public void RemoveRequest()
	{
	}

	private void Update()
	{
	}

	private void UpdateMuffle()
	{
	}
}
