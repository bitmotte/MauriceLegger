using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using UnityEngine;

namespace NewBlood.Rendering
{
	public static class RenderThread
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void UnityRenderingEventDelegate(int eventId);

		private readonly struct PluginEvent
		{
			public object? State { get; }

			public SendOrPostCallback Callback { get; }

			public PluginEvent(SendOrPostCallback callback, object? state)
			{
				State = null;
				Callback = null;
			}
		}

		private const int InitialCapacity = 16;

		private static int s_NextEventId;

		private static int s_MainThreadId;

		private static readonly Dictionary<int, PluginEvent> s_EventQueue;

		private static readonly UnityRenderingEventDelegate s_SendHandler;

		private static readonly IntPtr s_SendHandlerPtr;

		private static readonly UnityRenderingEventDelegate s_PostHandler;

		private static readonly IntPtr s_PostHandlerPtr;

		private static readonly ManualResetEventSlim s_WaitHandle;

		public static void Send(SendOrPostCallback callback, object? state)
		{
		}

		public static void Post(SendOrPostCallback callback, object? state)
		{
		}

		private static void QueuePluginEvent(SendOrPostCallback callback, object? state, IntPtr handler)
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void OnSubsystemRegistration()
		{
		}

		private static void ThrowIfNotMainThread([CallerMemberName] string? caller = null)
		{
		}

		[MonoPInvokeCallback(typeof(UnityRenderingEventDelegate))]
		private static void OnUnityRenderingEventSend(int eventId)
		{
		}

		[MonoPInvokeCallback(typeof(UnityRenderingEventDelegate))]
		private static void OnUnityRenderingEventPost(int eventId)
		{
		}

		private static void InvokePluginEvent(int eventId)
		{
		}
	}
}
