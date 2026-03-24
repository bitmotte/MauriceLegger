using Interop;
using Interop.Unity;

public static class InteropObjectExtensions
{
	public unsafe static Type* GetTypeVirtualInternal<T>(this ref T @this) where T : unmanaged, Object.Interface
	{
		//IL_0002: Expected I, but got O
		return (Type*)unchecked((nint)0);
	}
}
