namespace Interop.Physics
{
	public struct ShapeHandle
	{
		[NativeTypeName("Physics::SDKObjectHandle")]
		public unsafe void* shapePtr;

		[NativeTypeName("Physics::SDKObjectHandle")]
		public unsafe void* scenePtr;

		[NativeTypeName("Physics::SDKObjectHandle")]
		public unsafe void* bodyPtr;
	}
}
