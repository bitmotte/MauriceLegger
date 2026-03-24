using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
[BurstCompile]
public class BloodsplatterManager : MonoSingleton<BloodsplatterManager>
{
	public struct InstanceProperties
	{
		public float3 pos;

		public int parentIndex;

		public float3 norm;

		public int clipState;

		public const int SIZE = 32;
	}

	private struct VertexData_Simple
	{
		public float3 position;

		public half4 normal;

		public half2 uv;
	}

	public class CachedColliderData
	{
		public GameObject go;

		public BloodstainParent parent;

		public IBloodstainReceiver receiver;

		public bool displace;

		public bool noLayers;

		public bool is7SObject;

		public CachedColliderData(ComponentsDatabase cdatabase, in RaycastHit hit, GameObject gameObject)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAsyncInit_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BloodsplatterManager _003C_003E4__this;

		public BSType bloodSplatterType;

		private Queue<GameObject> _003Cqueue_003E5__2;

		private int _003Camount_003E5__3;

		private AsyncInstantiateOperation<GameObject> _003CasyncOp_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAsyncInit_003Ed__105(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	internal delegate int CreateBloodstain_000002AE_0024PostfixBurstDelegate(ref int propIndex, ref int currentBloodCount, ref NativeArray<InstanceProperties> props, in float3 pos, in float3 norm, bool clipToSurface, int parent = 0);

	internal static class CreateBloodstain_000002AE_0024BurstDirectCall
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

		public static int Invoke(ref int propIndex, ref int currentBloodCount, ref NativeArray<InstanceProperties> props, in float3 pos, in float3 norm, bool clipToSurface, int parent = 0)
		{
			return 0;
		}
	}

	public float normalForgiveness;

	public bool forceOn;

	public bool forceGibs;

	public bool neverFreezeGibs;

	public bool overrideBloodstainChance;

	public float bloodstainChance;

	public GameObject head;

	public GameObject limb;

	public GameObject body;

	public GameObject small;

	public GameObject smallest;

	public GameObject splatter;

	public GameObject underwater;

	public GameObject sand;

	public GameObject blessing;

	public GameObject chestExplosion;

	public GameObject brainChunk;

	public GameObject skullChunk;

	public GameObject eyeball;

	public GameObject jawChunk;

	public GameObject[] gib;

	private int currentBloodCount;

	public GameObject bloodStain;

	public Shader bloodCompositeShader;

	public Material bloodCompositeMaterial;

	public Mesh stainMesh;

	public Material stainMat;

	public NativeArray<InstanceProperties> checkpointProps;

	public NativeArray<Matrix4x4> checkpointParents;

	private int checkpointPropIndex;

	public int checkpointParentIndex;

	public int checkpointBloodCount;

	public NativeArray<InstanceProperties> props;

	public NativeArray<Matrix4x4> parents;

	private int propIndex;

	private int parentIndex;

	public ComputeBuffer instanceBuffer;

	public ComputeBuffer parentBuffer;

	public ComputeBuffer argsBuffer;

	private uint[] argsData;

	private Dictionary<BSType, Queue<GameObject>> gorePool;

	private Dictionary<BSType, int> defaultHPValues;

	private int order;

	private VertexAttributeDescriptor[] vertexLayoutInstanced;

	private VertexAttributeDescriptor[] vertexLayoutNonInstanced;

	private Transform goreStore;

	public bool hasBloodFillers;

	public HashSet<GameObject> bloodFillers;

	public AudioMixerGroup goreAudioGroup;

	public AudioClip splatterClip;

	[HideInInspector]
	public int bloodDestroyers;

	[HideInInspector]
	public int bloodAbsorbers;

	[HideInInspector]
	public int bloodAbsorberChildren;

	public const float PARTICLE_COLLISION_STEP_DT = 0.128f;

	public TimeSince sinceLastStep;

	private OptionsManager opm;

	public Dictionary<int, Bloodsplatter> splatters;

	public NativeQueue<BloodstainCreateCommand> stainCreateQueue;

	public bool usedComputeShadersAtStart;

	public bool meshDirty;

	public Mesh totalStainMesh;

	public GenerateBloodMeshJob generateBloodMeshJob;

	private JobHandle generateBloodMeshJobHandle;

	private Mesh.MeshDataArray meshDataArray;

	public Mesh optimizedBloodMesh;

	private ComponentsDatabase cdatabase;

	private const string VERTEX_DISPLACEMENT = "VERTEX_DISPLACEMENT";

	private Dictionary<int, CachedColliderData> colliderDatas;

	public bool goreOn => false;

	public event Action<int> reuseParentIndex
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<int> reuseStainIndex
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action StainsCleared
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<float> ParticleCollisionStep
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action PostCollisionStep
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void SaveBloodstains()
	{
	}

	public void LoadBloodstains()
	{
	}

	public int CreateBloodstain(Vector3 pos, Vector3 norm, bool clipToSurface, int parent = 0)
	{
		return 0;
	}

	[BurstCompile]
	private static int CreateBloodstain(ref int propIndex, ref int currentBloodCount, ref NativeArray<InstanceProperties> props, in float3 pos, in float3 norm, bool clipToSurface, int parent = 0)
	{
		return 0;
	}

	public void DeleteBloodstain(int index)
	{
	}

	public int CreateParent(Matrix4x4 initialMatrix)
	{
		return 0;
	}

	public float GetBloodstainChance()
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void PlayBloodSound(Vector3 position)
	{
	}

	private void Update()
	{
	}

	private void RebuildMesh()
	{
	}

	private void LateUpdate()
	{
	}

	public void ClearStains()
	{
	}

	private void OnDestroy()
	{
	}

	private GameObject GetPrefabByBSType(BSType bloodType)
	{
		return null;
	}

	private void InitPools()
	{
	}

	private void InitPool(BSType bloodSplatterType)
	{
	}

	[IteratorStateMachine(typeof(_003CAsyncInit_003Ed__105))]
	private IEnumerator AsyncInit(BSType bloodSplatterType)
	{
		return null;
	}

	public void RepoolGore(Bloodsplatter bs, BSType type)
	{
	}

	public void RepoolGore(GameObject go, BSType type)
	{
	}

	private void ReturnToQueue(GameObject go, BSType type)
	{
	}

	public GameObject GetFromQueue(BSType type)
	{
		return null;
	}

	public GameObject GetGore(GoreType got, EnemyIdentifier eid, bool fromExplosion = false)
	{
		return null;
	}

	public GameObject GetGore(GoreType got, bool isUnderwater = false, bool isSandified = false, bool isBlessed = false, EnemyIdentifier eid = null, bool fromExplosion = false)
	{
		return null;
	}

	private void PrepareGore(GameObject gob, int healthChange = -1, EnemyIdentifier eid = null, bool fromExplosion = false)
	{
	}

	public GameObject GetGib(BSType type)
	{
		return null;
	}

	private AudioSource GetOriginalAudio(GoreType got)
	{
		return null;
	}

	private float GetSplatterWeight(GoreType got)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile]
	internal static int CreateBloodstain_0024BurstManaged(ref int propIndex, ref int currentBloodCount, ref NativeArray<InstanceProperties> props, in float3 pos, in float3 norm, bool clipToSurface, int parent = 0)
	{
		return 0;
	}
}
