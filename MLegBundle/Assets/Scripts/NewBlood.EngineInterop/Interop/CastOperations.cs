using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Interop
{
	public static class CastOperations
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static class UpCasts
		{
			public unsafe static ref TTo static_cast<TFrom, TTo>(ref TFrom from) where TFrom : struct, IUpCastable<TTo> where TTo : struct
			{
				return ref Unsafe.NullRef<TTo>();
			}

			public unsafe static TTo* static_cast<TFrom, TTo>(TFrom* from) where TFrom : unmanaged, IUpCastable<TTo> where TTo : unmanaged
			{
				//IL_0002: Expected I, but got O
				return (TTo*)unchecked((nint)0);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public static class DownCasts
		{
			public unsafe static ref TTo static_cast<TFrom, TTo>(ref TFrom from) where TFrom : struct where TTo : struct, IUpCastable<TFrom>
			{
				return ref Unsafe.NullRef<TTo>();
			}

			public unsafe static TTo* static_cast<TFrom, TTo>(TFrom* from) where TFrom : unmanaged where TTo : unmanaged, IUpCastable<TFrom>
			{
				//IL_0002: Expected I, but got O
				return (TTo*)unchecked((nint)0);
			}
		}

		public unsafe static ref TTo UpCast<TFrom, TTo>(ref TFrom from) where TFrom : struct, IUpCastable<TTo> where TTo : struct
		{
			return ref Unsafe.NullRef<TTo>();
		}

		public unsafe static TTo* UpCast<TFrom, TTo>(TFrom* from) where TFrom : unmanaged, IUpCastable<TTo> where TTo : unmanaged
		{
			//IL_0002: Expected I, but got O
			return (TTo*)unchecked((nint)0);
		}

		public unsafe static ref TTo DownCast<TFrom, TTo>(ref TFrom from) where TFrom : struct where TTo : struct, IUpCastable<TFrom>
		{
			return ref Unsafe.NullRef<TTo>();
		}

		public unsafe static TTo* DownCast<TFrom, TTo>(TFrom* from) where TFrom : unmanaged where TTo : unmanaged, IUpCastable<TFrom>
		{
			//IL_0002: Expected I, but got O
			return (TTo*)unchecked((nint)0);
		}

		[DoesNotReturn]
		public static Exception ThrowAmbiguousCast()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static nint GetOffsetFromBase<TBase, TDerived>() where TBase : struct where TDerived : struct, IUpCastable<TBase>
		{
			return 0;
		}
	}
}
