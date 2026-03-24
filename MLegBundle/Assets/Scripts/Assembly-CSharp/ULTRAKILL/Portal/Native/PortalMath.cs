using Unity.Mathematics;

namespace ULTRAKILL.Portal.Native
{
	public static class PortalMath
	{
		public static bool Raycast(in PortalRay ray, in float4x4 mat, in float2 dimensions, out float3 point, out float distance, bool allowBackface = false)
		{
			point = default(float3);
			distance = default(float);
			return false;
		}
	}
}
