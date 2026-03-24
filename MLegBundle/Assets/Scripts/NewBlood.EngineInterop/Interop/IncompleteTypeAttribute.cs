using System;

namespace Interop
{
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum)]
	public sealed class IncompleteTypeAttribute : Attribute
	{
	}
}
