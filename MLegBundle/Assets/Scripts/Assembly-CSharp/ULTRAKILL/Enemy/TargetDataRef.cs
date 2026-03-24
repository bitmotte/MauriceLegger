using System;
using ULTRAKILL.Portal;
using Unity.Mathematics;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace ULTRAKILL.Enemy
{
	public readonly ref struct TargetDataRef
	{
		private readonly Span<TargetDataArrays> _arr;

		private readonly Span<float4x4> _matrix;

		private readonly Span<PortalHandleSequence> _portalHandleSequence;

		public readonly PortalScene scene;

		public readonly ITarget target;

		public int Index => 0;

		public unsafe ref Matrix4x4 portalMatrix => ref *(Matrix4x4*)null;

		public unsafe ref PortalHandleSequence portals => ref Unsafe.NullRef<PortalHandleSequence>();

		public bool isSequenceCulled => false;

		public bool isAcrossPortals => false;

		public unsafe ref Vector3 position => ref *(Vector3*)null;

		public unsafe ref Vector3 headPosition => ref *(Vector3*)null;

		public unsafe ref Vector3 velocity => ref *(Vector3*)null;

		public TargetDataRef(PortalScene scene, ITarget target, Span<float4x4> matrix, Span<PortalHandleSequence> sequence, Span<TargetDataArrays> arr)
		{
			_arr = default(Span<TargetDataArrays>);
			_matrix = default(Span<float4x4>);
			_portalHandleSequence = default(Span<PortalHandleSequence>);
			this.scene = null;
			this.target = null;
		}

		public TargetHandle CreateHandle()
		{
			return null;
		}
	}
}
