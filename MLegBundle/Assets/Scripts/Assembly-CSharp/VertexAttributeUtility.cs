using System;
using UnityEngine.Rendering;

public static class VertexAttributeUtility
{
	public const VertexAttribute MaxVertexAttribute = VertexAttribute.BlendIndices;

	public static int GetFormatSize(VertexAttributeFormat format)
	{
		return 0;
	}

	public static int GetAttributeCount(VertexAttributeUsage usage)
	{
		return 0;
	}

	public static int GetAttributeSize(VertexAttributeDescriptor attribute)
	{
		return 0;
	}

	public static VertexAttributeDescriptor GetAttributeDescriptor(VertexAttribute attribute, int stream)
	{
		return default(VertexAttributeDescriptor);
	}

	public static int GetVertexStreamForSkinning(VertexAttribute attribute)
	{
		return 0;
	}

	public static void UpdateVertexStreamsForSkinning(Span<VertexAttributeDescriptor> attributes)
	{
	}

	public static void GetAttributesForSkinning(VertexAttributeUsage usage, Span<VertexAttributeDescriptor> attributes)
	{
	}

	public static VertexAttributeDescriptor[] GetAttributesForSkinning(VertexAttributeUsage usage)
	{
		return null;
	}

	public static VertexAttributeFormat GetNormalizedFormat(VertexAttributeFormat format)
	{
		return default(VertexAttributeFormat);
	}
}
