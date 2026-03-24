using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;

namespace ULTRAKILL.Portal.Native
{
	[BurstCompile]
	public struct NativePortalScene : IDisposable
	{
		internal delegate void UpdateTravelMatrices_00002A94_0024PostfixBurstDelegate(ref NativePortal enter, ref NativePortal exit);

		internal static class UpdateTravelMatrices_00002A94_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static void Invoke(ref NativePortal enter, ref NativePortal exit)
			{
			}
		}

		[MarshalAs(UnmanagedType.U1)]
		public bool valid;

		public NativeHashMap<int, int> idToIndex;

		public NativeList<NativePortal> portals;

		public static NativePortalScene Create(List<Portal> portalComponents)
		{
			return default(NativePortalScene);
		}

		[BurstCompile]
		private static void UpdateTravelMatrices(ref NativePortal enter, ref NativePortal exit)
		{
		}

		public void Recalculate(List<Portal> components)
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void UpdateTravelMatrices_0024BurstManaged(ref NativePortal enter, ref NativePortal exit)
		{
		}
	}
}
