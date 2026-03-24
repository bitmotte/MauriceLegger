using System;

namespace Interop
{
	public interface IPointer
	{
		unsafe void* Value { get; }

		Type PointerType { get; }

		private protected bool IsPointer { get; }
	}
}
