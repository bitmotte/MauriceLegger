using System;
using System.Runtime.CompilerServices;

namespace Interop
{
	public struct InlineArray21<T>
	{
		private T t;

		private T _1;

		private T _2;

		private T _3;

		private T _4;

		private T _5;

		private T _6;

		private T _7;

		private T _8;

		private T _9;

		private T _10;

		private T _11;

		private T _12;

		private T _13;

		private T _14;

		private T _15;

		private T _16;

		private T _17;

		private T _18;

		private T _19;

		private T _20;

		public unsafe readonly ref T this[int index] => ref Unsafe.NullRef<T>();

		public unsafe readonly ref T this[Index index] => ref Unsafe.NullRef<T>();

		public readonly Span<T> this[Range range] => default(Span<T>);

		public static implicit operator ReadOnlySpan<T>(in InlineArray21<T> array)
		{
			return default(ReadOnlySpan<T>);
		}

		public static implicit operator Span<T>(in InlineArray21<T> array)
		{
			return default(Span<T>);
		}
	}
}
