using System.Collections.Generic;

public static class DictionaryCollectionExtensions
{
	public static void Add<TKey, TCollection, TValue>(this Dictionary<TKey, TCollection> dictionary, TKey key, TValue value) where TCollection : ICollection<TValue>, new()
	{
	}

	public static bool Remove<TKey, TCollection, TValue>(this Dictionary<TKey, TCollection> dictionary, TKey key, TValue value) where TCollection : ICollection<TValue>, new()
	{
		return false;
	}
}
