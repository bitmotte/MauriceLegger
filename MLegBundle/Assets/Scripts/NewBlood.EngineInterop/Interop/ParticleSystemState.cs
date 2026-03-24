using Interop.core;
using UnityEngine;

namespace Interop
{
	public struct ParticleSystemState
	{
		public enum PhysicsState
		{
			kNeedsRigidbody = 0,
			kUsingRigidbody = 1,
			kUsingRigidbody2D = 2,
			kNoAvailableRigidbody = 3
		}

		public enum PlayState
		{
			kStopped = 0,
			kPlaying = 1,
			kPaused = 2
		}

		public float accumulatedDt;

		public float delayT;

		public PlayState playState;

		[NativeTypeName("bool")]
		public byte needRestart;

		[NativeTypeName("bool")]
		public byte stopEmitting;

		public nuint rayBudget;

		public nuint nextParticleToTrace;

		[NativeTypeName("bool")]
		public byte isSubEmitter;

		[NativeTypeName("bool")]
		public byte supportsProcedural;

		[NativeTypeName("bool")]
		public byte invalidateProcedural;

		[NativeTypeName("bool")]
		public byte invalidateTransform;

		[NativeTypeName("bool")]
		public byte scriptSupplied3DRotation;

		[NativeTypeName("bool")]
		public byte scriptSupplied3DSize;

		[NativeTypeName("bool")]
		public byte culled;

		[NativeTypeName("bool")]
		public byte firstUpdate;

		public double cullTime;

		public double stopTime;

		public int numLoops;

		[NativeTypeName("Matrix4x4f")]
		public Matrix4x4 localToWorld;

		[NativeTypeName("Quaternionf")]
		public Quaternion localToWorldRotation;

		[NativeTypeName("Matrix4x4f")]
		public Matrix4x4 worldToLocal;

		public Matrix3x3f localRotation;

		[NativeTypeName("Vector3f")]
		public Vector3 oldPosition;

		[NativeTypeName("Vector3f")]
		public Vector3 emitterVelocity;

		[NativeTypeName("Vector3f")]
		public Vector3 emitterScale;

		[NativeTypeName("Vector3f")]
		public Vector3 renderScale;

		[NativeTypeName("bool")]
		public byte usingWorldRenderAlignment;

		[NativeTypeName("bool")]
		public byte usingPhysics;

		[NativeTypeName("Vector3f")]
		public Vector3 oldRigidBodyPosition;

		[NativeTypeName("Vector3f")]
		public Vector3 currentRigidBodyPosition;

		[NativeTypeName("Vector3f")]
		public Vector3 currentRigidBodyVelocity;

		public PPtr<Rigidbody2D> rigidbody2D;

		public PPtr<Rigidbody> rigidbody;

		public PhysicsState physicsState;

		public MinMaxAABB minMaxAABB;

		public float maxSize;

		public float t;

		public int ringBufferIndex;

		public vector<ParticleSystemEmitReplay> emitReplay;

		public ParticleSystemEmissionState emissionState;

		public vector<BatchedColliderResult> colliderForces;
	}
}
