using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct Destroyable : Destroyable.Interface, IUpCastable<Destroyable>
	{
		public struct Vtbl<T> where T : unmanaged, Interface
		{
			public unsafe delegate* unmanaged[Thiscall]<T*, void> __dtor;
		}

		public interface Interface : IUpCastable<Destroyable>
		{
		}

		public unsafe void** __vftable;

		unsafe ref Destroyable IUpCastable<Destroyable>.Cast()
		{
			return ref *(Destroyable*)null;
		}
	}
}
