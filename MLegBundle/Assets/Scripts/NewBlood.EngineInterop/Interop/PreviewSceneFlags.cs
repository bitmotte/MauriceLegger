using System;

namespace Interop
{
	[Flags]
	public enum PreviewSceneFlags
	{
		NoFlags = 0,
		IsPreviewScene = 1,
		AllowCamerasForRendering = 2,
		AllowMonoBehaviourEvents = 4,
		AllowGlobalIlluminationLights = 8,
		AllowAutoPlayAudioSources = 0x10,
		AllFlags = 0x1F
	}
}
