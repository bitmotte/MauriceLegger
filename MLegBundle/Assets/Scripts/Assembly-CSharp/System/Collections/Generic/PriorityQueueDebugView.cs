using System.Diagnostics;

namespace System.Collections.Generic
{
	internal sealed class PriorityQueueDebugView<TElement, TPriority>
	{
		private readonly PriorityQueue<TElement, TPriority> _queue;

		private readonly bool _sort;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public (TElement Element, TPriority Priority)[] Items => null;

		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority> queue)
		{
		}

		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority>.UnorderedItemsCollection collection)
		{
		}
	}
}
