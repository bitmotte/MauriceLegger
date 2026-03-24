namespace Interop.std
{
	[SupportsInheritance]
	public struct function : function.Interface, IUpCastable<function>
	{
		public interface Interface : IUpCastable<function>
		{
		}

		private unsafe fixed ulong _buffer0[2];

		private InlineArray6<nuint> _buffer1;

		unsafe ref function IUpCastable<function>.Cast()
		{
			return ref *(function*)null;
		}
	}
}
