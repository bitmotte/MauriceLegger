using System;
using System.Runtime.CompilerServices;

namespace Interop
{
	public readonly struct Pointer : IEquatable<Pointer>, IComparable<Pointer>, IComparable, IPointer
	{
		public unsafe readonly void* Value;

		bool IPointer.IsPointer => false;

		unsafe void* IPointer.Value => (void*)unchecked((nint)0);

		Type IPointer.PointerType => null;

		public unsafe Pointer(void* value)
		{
			//IL_0007: Expected I, but got O
			Value = (void*)unchecked((nint)0);
		}

		public unsafe static implicit operator void*(Pointer pointer)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)0);
		}

		public unsafe static implicit operator Pointer(void* pointer)
		{
			return default(Pointer);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Pointer other)
		{
			return false;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(Pointer other)
		{
			return 0;
		}
	}
	public readonly struct Pointer<T> : IEquatable<Pointer<T>>, IComparable<Pointer<T>>, IEquatable<Pointer>, IComparable<Pointer>, IComparable, IPointer where T : unmanaged
	{
		public unsafe readonly T* Value;

		bool IPointer.IsPointer => false;

		unsafe void* IPointer.Value => (void*)unchecked((nint)0);

		Type IPointer.PointerType => null;

		public unsafe Pointer(T* value)
		{
			//IL_0007: Expected I, but got O
			Value = (T*)unchecked((nint)0);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Pointer<T> other)
		{
			return false;
		}

		public bool Equals(Pointer other)
		{
			return false;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(Pointer<T> other)
		{
			return 0;
		}

		public int CompareTo(Pointer other)
		{
			return 0;
		}

		public unsafe static implicit operator T*(Pointer<T> pointer)
		{
			//IL_0002: Expected I, but got O
			return (T*)unchecked((nint)0);
		}

		public unsafe static implicit operator Pointer<T>(T* pointer)
		{
			return default(Pointer<T>);
		}

		public unsafe static implicit operator void*(Pointer<T> pointer)
		{
			//IL_0002: Expected I, but got O
			return (void*)unchecked((nint)0);
		}

		public static implicit operator Pointer(Pointer<T> pointer)
		{
			return default(Pointer);
		}

		public unsafe static explicit operator Pointer<T>(void* pointer)
		{
			return default(Pointer<T>);
		}

		public static explicit operator Pointer<T>(Pointer pointer)
		{
			return default(Pointer<T>);
		}
	}
}
