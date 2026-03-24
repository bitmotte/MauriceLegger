using System.Collections;
using System.Collections.Generic;

public sealed class ReferenceEqualityComparer : IEqualityComparer<object?>, IEqualityComparer
{
	public static ReferenceEqualityComparer Instance { get; }

	private ReferenceEqualityComparer()
	{
	}

	public new bool Equals(object? x, object? y)
	{
		return false;
	}

	public int GetHashCode(object? obj)
	{
		return 0;
	}
}
