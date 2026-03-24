using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;

[BurstCompile]
[DisallowMultipleComponent]
public sealed class VirtualAudioFilter : MonoBehaviour
{
	internal unsafe delegate void ProcessStereo_000021E1_0024PostfixBurstDelegate(float* data, int sampleCount, float gainL, float gainR);

	internal static class ProcessStereo_000021E1_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public unsafe static void Invoke(float* data, int sampleCount, float gainL, float gainR)
		{
		}
	}

	private const float SpeedOfSound = 340f;

	private const float InvSpeedOfSound = 0.0029411765f;

	private AudioSource _source;

	private float _gainL;

	private float _gainR;

	private float _weight;

	private ulong _gain;

	[SerializeField]
	[HideInInspector]
	private bool _ranAwake;

	[Range(-3f, 3f)]
	[SerializeField]
	private float _pitch;

	[Range(0f, 1f)]
	[SerializeField]
	private float _spatialBlend;

	private float _dopplerPitch;

	private Vector3 _lastPosition;

	private float _closestDistance;

	private Vector3 _closestPosition;

	private int _updateIndex;

	private Rigidbody _rigidBody;

	private bool _hasRigidBody;

	internal int trackedIndex { get; set; }

	public AudioSource source => null;

	public float spatialBlend
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float pitch
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void UpdateCachedValues(int updateIndex)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetAudioSource()
	{
	}

	internal void UpdateVelocity(VirtualAudioManager manager)
	{
	}

	internal void BeginUpdate()
	{
	}

	internal void AddOutput(Vector3 listenerPosition, Vector3 listenerRight, Vector3 position, float initialDistance)
	{
	}

	internal void AddOutput(Vector3 listenerPosition, Vector3 listenerRight, Vector3 position, float initialDistance, float spatialBlend)
	{
	}

	internal void EndUpdate()
	{
	}

	private static float GetAttenuationFactor(AudioSource source, float distance)
	{
		return 0f;
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	[BurstCompile]
	private unsafe static void ProcessStereo(float* data, int sampleCount, float gainL, float gainR)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	internal unsafe static void ProcessStereo_0024BurstManaged(float* data, int sampleCount, float gainL, float gainR)
	{
	}
}
