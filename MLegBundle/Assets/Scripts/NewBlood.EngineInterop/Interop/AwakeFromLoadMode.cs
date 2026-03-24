using System;

namespace Interop
{
	[Flags]
	public enum AwakeFromLoadMode
	{
		kDefaultAwakeFromLoad = 0,
		kDidLoadFromDisk = 1,
		kDidLoadThreaded = 2,
		kInstantiateOrCreateFromCodeAwakeFromLoad = 4,
		kActivateAwakeFromLoad = 8,
		kAnimationAwakeFromLoad = 0x10,
		kWillUnloadAfterWritingBuildData = 0x20,
		kPersistentManagerAwakeFromLoadMode = 3,
		kDefaultAwakeFromLoadInvalid = 0xFF
	}
}
