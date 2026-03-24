using System;

namespace Interop
{
	internal static class InlineArrayHelper
	{
		public static Span<T> AsSpan<T, TArray>(ref TArray array) where TArray : struct
		{
			return default(Span<T>);
		}

		public static ReadOnlySpan<T> AsReadOnlySpan<T, TArray>(in TArray array) where TArray : struct
		{
			return default(ReadOnlySpan<T>);
		}
	}
}
