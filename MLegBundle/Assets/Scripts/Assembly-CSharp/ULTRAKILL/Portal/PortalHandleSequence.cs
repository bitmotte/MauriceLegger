using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ULTRAKILL.Portal
{
	public readonly struct PortalHandleSequence : IEquatable<PortalHandleSequence>, IEquatable<PortalHandle>, IEnumerable<PortalHandle>, IEnumerable, IEquatable<PortalTraversalV2[]>
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__22 : IEnumerator<PortalHandle>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private PortalHandle _003C_003E2__current;

			public PortalHandleSequence _003C_003E4__this;

			private int _003Ci_003E5__2;

			PortalHandle IEnumerator<PortalHandle>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(PortalHandle);
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
			public _003CGetEnumerator_003Ed__22(int _003C_003E1__state)
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

		private readonly PortalHandle[] handles;

		private readonly byte count;

		public static readonly PortalHandleSequence Empty;

		public int Count => 0;

		public bool IsEmpty => false;

		public PortalHandle this[int index]
		{
			get
			{
				return default(PortalHandle);
			}
			set
			{
			}
		}

		public static PortalHandleSequence OfDepth(int depth)
		{
			return default(PortalHandleSequence);
		}

		public PortalHandleSequence Then(PortalScene scene, PortalHandle handle)
		{
			return default(PortalHandleSequence);
		}

		public Span<PortalHandle> AsSpan()
		{
			return default(Span<PortalHandle>);
		}

		public PortalHandleSequence Append(PortalHandle handle)
		{
			return default(PortalHandleSequence);
		}

		public PortalHandleSequence StartFrom(PortalScene scene, PortalHandle handle)
		{
			return default(PortalHandleSequence);
		}

		public PortalHandleSequence Prepend(PortalHandle handle)
		{
			return default(PortalHandleSequence);
		}

		public PortalHandleSequence RemoveLast()
		{
			return default(PortalHandleSequence);
		}

		public PortalHandleSequence(params PortalTraversalV2[] traversals)
		{
			handles = null;
			count = 0;
		}

		public PortalHandleSequence(params PortalHandle[] handles)
		{
			this.handles = null;
			count = 0;
		}

		public static PortalHandleSequence Prepend(PortalHandle handle, params PortalTraversalV2[] traversals)
		{
			return default(PortalHandleSequence);
		}

		public bool MatchesTraversals(in PortalTraversalV2[] traversals)
		{
			return false;
		}

		public PortalHandleSequence Reversed()
		{
			return default(PortalHandleSequence);
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__22))]
		public IEnumerator<PortalHandle> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private int ComputeHashCode()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(PortalHandleSequence other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(PortalHandleSequence left, PortalHandleSequence right)
		{
			return false;
		}

		public static bool operator !=(PortalHandleSequence left, PortalHandleSequence right)
		{
			return false;
		}

		public bool Equals(PortalHandle other)
		{
			return false;
		}

		public bool Equals(PortalTraversalV2[] other)
		{
			return false;
		}

		public static bool operator ==(PortalHandleSequence left, PortalTraversalV2[] right)
		{
			return false;
		}

		public static bool operator !=(PortalHandleSequence left, PortalTraversalV2[] right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
