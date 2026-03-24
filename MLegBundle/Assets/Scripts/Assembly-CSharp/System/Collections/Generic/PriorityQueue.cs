using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
	public class PriorityQueue<TElement, TPriority>
	{
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
		public sealed class UnorderedItemsCollection : IReadOnlyCollection<(TElement Element, TPriority Priority)>, IEnumerable<(TElement Element, TPriority Priority)>, IEnumerable, ICollection
		{
			public struct Enumerator : IEnumerator<(TElement Element, TPriority Priority)>, IEnumerator, IDisposable
			{
				private readonly PriorityQueue<TElement, TPriority> _queue;

				private readonly int _version;

				private int _index;

				private (TElement, TPriority) _current;

				public (TElement Element, TPriority Priority) Current => default((TElement, TPriority));

				object IEnumerator.Current => null;

				internal Enumerator(PriorityQueue<TElement, TPriority> queue)
				{
					_queue = null;
					_version = 0;
					_index = 0;
					_current = default((TElement, TPriority));
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				private bool MoveNextRare()
				{
					return false;
				}

				void IEnumerator.Reset()
				{
				}
			}

			internal readonly PriorityQueue<TElement, TPriority> _queue;

			public int Count => 0;

			object ICollection.SyncRoot => null;

			bool ICollection.IsSynchronized => false;

			internal UnorderedItemsCollection(PriorityQueue<TElement, TPriority> queue)
			{
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			public Enumerator GetEnumerator()
			{
				return default(Enumerator);
			}

			IEnumerator<(TElement Element, TPriority Priority)> IEnumerable<(TElement Element, TPriority Priority)>.GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static class SR
		{
			public const string InvalidOperation_EmptyQueue = "Queue empty.";

			public const string Arg_RankMultiDimNotSupported = "Only single dimensional arrays are supported for the requested action.";

			public const string Arg_NonZeroLowerBound = "The lower bound of target array must be zero.";

			public const string ArgumentOutOfRange_IndexMustBeLessOrEqual = "Index was out of range. Must be non-negative and less than or equal to the size of the collection.";

			public const string Argument_InvalidOffLen = "Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.";

			public const string Argument_IncompatibleArrayType = "Target array type is not compatible with the type of items in the collection.";

			public const string InvalidOperation_EnumFailedVersion = "Collection was modified after the enumerator was instantiated.";
		}

		private (TElement Element, TPriority Priority)[] _nodes;

		private readonly IComparer<TPriority>? _comparer;

		private UnorderedItemsCollection? _unorderedItems;

		private int _size;

		private int _version;

		private const int Arity = 4;

		private const int Log2Arity = 2;

		public int Count => 0;

		public int Capacity => 0;

		public IComparer<TPriority> Comparer => null;

		public UnorderedItemsCollection UnorderedItems => null;

		public PriorityQueue()
		{
		}

		public PriorityQueue(int initialCapacity)
		{
		}

		public PriorityQueue(IComparer<TPriority>? comparer)
		{
		}

		public PriorityQueue(int initialCapacity, IComparer<TPriority>? comparer)
		{
		}

		public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items)
		{
		}

		public PriorityQueue(IEnumerable<(TElement Element, TPriority Priority)> items, IComparer<TPriority>? comparer)
		{
		}

		public void Enqueue(TElement element, TPriority priority)
		{
		}

		public TElement Peek()
		{
			return default(TElement);
		}

		public TElement Dequeue()
		{
			return default(TElement);
		}

		public TElement DequeueEnqueue(TElement element, TPriority priority)
		{
			return default(TElement);
		}

		public bool TryDequeue([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			element = default(TElement);
			priority = default(TPriority);
			return false;
		}

		public bool TryPeek([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			element = default(TElement);
			priority = default(TPriority);
			return false;
		}

		public TElement EnqueueDequeue(TElement element, TPriority priority)
		{
			return default(TElement);
		}

		public void EnqueueRange(IEnumerable<(TElement Element, TPriority Priority)> items)
		{
		}

		public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority)
		{
		}

		public bool Remove(TElement element, [MaybeNullWhen(false)] out TElement removedElement, [MaybeNullWhen(false)] out TPriority priority, IEqualityComparer<TElement>? equalityComparer = null)
		{
			removedElement = default(TElement);
			priority = default(TPriority);
			return false;
		}

		public void Clear()
		{
		}

		public int EnsureCapacity(int capacity)
		{
			return 0;
		}

		public void TrimExcess()
		{
		}

		private void Grow(int minCapacity)
		{
		}

		private void RemoveRootNode()
		{
		}

		private static int GetParentIndex(int index)
		{
			return 0;
		}

		private static int GetFirstChildIndex(int index)
		{
			return 0;
		}

		private void Heapify()
		{
		}

		private void MoveUpDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveUpCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveDownDefaultComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private void MoveDownCustomComparer((TElement Element, TPriority Priority) node, int nodeIndex)
		{
		}

		private int FindIndex(TElement element, IEqualityComparer<TElement>? equalityComparer)
		{
			return 0;
		}

		private static IComparer<TPriority>? InitializeComparer(IComparer<TPriority>? comparer)
		{
			return null;
		}
	}
}
