using System;
using System.Runtime.CompilerServices;

namespace Interop
{
	public struct InlineArray4<T>
	{
		private T t;

		private T _1;

		private T _2;

		private T _3;

		public unsafe readonly ref T this[int index] => ref Unsafe.NullRef<T>();

		public unsafe readonly ref T this[Index index] => ref Unsafe.NullRef<T>();

		public readonly Span<T> this[Range range] => default(Span<T>);

		public static implicit operator ReadOnlySpan<T>(in InlineArray4<T> array)
		{
			return default(ReadOnlySpan<T>);
		}

		public static implicit operator Span<T>(in InlineArray4<T> array)
		{
			return default(Span<T>);
		}
	}
}
