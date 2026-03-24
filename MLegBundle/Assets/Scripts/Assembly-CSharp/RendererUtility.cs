using System;
using System.Collections.Generic;
using UnityEngine;

internal static class RendererUtility
{
	public static Bounds GetBounds<T>(List<T> renderers, bool allowSMRs = true, HashSet<Renderer> renderersToIgnore = null) where T : Renderer
	{
		return default(Bounds);
	}

	public static Bounds GetBounds<T>(ReadOnlySpan<T> renderers, bool allowSMRs = true, HashSet<Renderer> renderersToIgnore = null) where T : Renderer
	{
		return default(Bounds);
	}
}
