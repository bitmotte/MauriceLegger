namespace Interop
{
	public interface IUpCastable<TTo> where TTo : struct
	{
		ref TTo Cast();
	}
}
