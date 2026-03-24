using System;

namespace Interop
{
	[AttributeUsage(AttributeTargets.Field)]
	internal sealed class DisallowEmptyTypeAttribute : Attribute
	{
		public string Message { get; }

		public DisallowEmptyTypeAttribute()
		{
		}

		public DisallowEmptyTypeAttribute(string message)
		{
		}
	}
}
