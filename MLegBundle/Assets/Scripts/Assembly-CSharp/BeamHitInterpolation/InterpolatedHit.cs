using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace BeamHitInterpolation
{
	public record InterpolatedHit
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Vector3 point;

		public Vector3 normal;

		public float distance;

		public Transform transform;

		public Rigidbody rigidbody;

		public Collider collider;

		public static InterpolatedHit FromRaycastHit(RaycastHit hit)
		{
			return null;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			return false;
		}

		[CompilerGenerated]
		public virtual bool Equals(InterpolatedHit? other)
		{
			return false;
		}

		[CompilerGenerated]
		protected InterpolatedHit(InterpolatedHit original)
		{
		}

		public InterpolatedHit()
		{
		}
	}
}
