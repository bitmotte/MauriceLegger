using System;
using System.Runtime.CompilerServices;

namespace Interop
{
	public struct InlineArray1<T>
	{
		private T t;

		public unsafe readonly ref T this[int index] => ref Unsafe.NullRef<T>();

		public unsafe readonly ref T this[Index index] => ref Unsafe.NullRef<T>();

		public readonly Span<T> this[Range range] => default(Span<T>);

		public static implicit operator ReadOnlySpan<T>(in InlineArray1<T> array)
		{
			return default(ReadOnlySpan<T>);
		}

		public static implicit operator Span<T>(in InlineArray1<T> array)
		{
			return default(Span<T>);
		}
	}
}
