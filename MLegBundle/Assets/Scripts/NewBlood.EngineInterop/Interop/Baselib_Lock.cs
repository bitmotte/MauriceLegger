using System;

namespace Interop
{
	public struct Baselib_Lock
	{
		[NonSerialized]
		public int state;

		[NonSerialized]
		public unsafe fixed sbyte _cachelineSpacer[60];
	}
}
