namespace Interop
{
	public struct AnimationAssetObserver
	{
		public unsafe AnimationAsset* m_Asset;

		public unsafe void* m_Observer;

		public unsafe delegate* unmanaged[Stdcall]<void*, AnimationAssetChangeEventType, void> m_Callback;
	}
}
