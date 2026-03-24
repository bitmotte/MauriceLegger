namespace Interop
{
	public struct UnityAudioAmbisonicData
	{
		public unsafe fixed float listenermatrix[16];

		public unsafe fixed float sourcematrix[16];

		public float spatialblend;

		public float reverbzonemix;

		public float spread;

		public float stereopan;

		public unsafe delegate* unmanaged[Stdcall]<UnityAudioEffectState*, float, float, float*, int> distanceattenuationcallback;

		public int ambisonicOutChannels;

		public float volume;
	}
}
