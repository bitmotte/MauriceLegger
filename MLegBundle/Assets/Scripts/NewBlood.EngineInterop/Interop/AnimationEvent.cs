using Interop.core;
using UnityEngine;

namespace Interop
{
	public struct AnimationEvent
	{
		public float time;

		public basic_string functionName;

		public basic_string stringParameter;

		public PPtr<Object> objectReferenceParameter;

		public float floatParameter;

		public int intParameter;

		public int messageOptions;

		public unsafe AnimationState* stateSender;

		public unsafe AnimatorStateInfo* animatorStateInfo;

		public unsafe AnimatorClipInfo* animatorClipInfo;
	}
}
