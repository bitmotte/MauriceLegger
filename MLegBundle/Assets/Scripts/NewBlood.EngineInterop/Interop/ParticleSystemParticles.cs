using Interop.core;
using UnityEngine;

namespace Interop
{
	public struct ParticleSystemParticles
	{
		public ParticleSystemVector3Array position;

		public ParticleSystemVector3Array velocity;

		public ParticleSystemVector3Array animatedVelocity;

		public ParticleSystemVector3Array initialVelocity;

		public ParticleSystemVector3Array axisOfRotation;

		public ParticleSystemVector3Array rotation;

		public ParticleSystemVector3Array rotationalSpeed;

		public ParticleSystemVector3Array startSize;

		public ParticleSystemVector3Array currentSize;

		[NativeTypeName("ParticleSystemColor32Array")]
		public vector<Color32> startColor;

		[NativeTypeName("ParticleSystemUInt32Array")]
		public vector<uint> randomSeed;

		[NativeTypeName("ParticleSystemUInt32Array")]
		public vector<uint> parentRandomSeed;

		[NativeTypeName("ParticleSystemFloatArray")]
		public vector<float> aliveTimePercent;

		[NativeTypeName("ParticleSystemFloatArray")]
		public vector<float> invStartLifetime;

		public ParticleSystemVector3Array noiseSum;

		public ParticleSystemVector3Array noiseImpulse;

		[NativeTypeName("ParticleSystemFloatArray")]
		public vector<float> speedModifier;

		[NativeTypeName("ParticleSystemFloatArray[2]")]
		public InlineArray2<vector<float>> emitAccumulator;

		public dynamic_bitset hasLight;

		public CollisionEvents collisionEvents;

		public TriggerEvents triggerEvents;

		public ParticleTrails trails;

		public InlineArray2<ParticleSystemVector4Array> customData;

		[NativeTypeName("ParticleSystemIntArray")]
		public vector<int> meshIndex;

		[NativeTypeName("bool")]
		public byte usesAxisOfRotation;

		[NativeTypeName("bool")]
		public byte usesRotationalSpeed;

		[NativeTypeName("bool")]
		public byte usesCurrentSize;

		[NativeTypeName("bool")]
		public byte uses3DRotation;

		[NativeTypeName("bool")]
		public byte uses3DSize;

		[NativeTypeName("bool")]
		public byte usesInitialVelocity;

		[NativeTypeName("bool")]
		public byte usesNoiseSum;

		[NativeTypeName("bool")]
		public byte usesNoiseImpulse;

		[NativeTypeName("bool")]
		public byte usesSpeedModifier;

		[NativeTypeName("bool")]
		public byte usesLights;

		[NativeTypeName("bool")]
		public byte usesTrails;

		[NativeTypeName("bool[2]")]
		public InlineArray2<byte> usesCustomData;

		[NativeTypeName("bool")]
		public byte usesCollisionEvents;

		[NativeTypeName("bool")]
		public byte usesTriggerEvents;

		[NativeTypeName("bool")]
		public byte usesParentRandomSeed;

		[NativeTypeName("bool")]
		public byte usesMeshIndex;

		public int numEmitAccumulators;

		public volatile int refCount;
	}
}
