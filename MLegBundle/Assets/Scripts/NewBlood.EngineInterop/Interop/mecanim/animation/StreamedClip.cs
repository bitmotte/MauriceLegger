namespace Interop.mecanim.animation
{
	public struct StreamedClip
	{
		public uint dataSize;

		public OffsetPtr<uint> data;

		public ushort curveCount;

		public ushort discreteCurveCount;
	}
}
