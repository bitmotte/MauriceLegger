using System;
using Interop.Unity;
using Interop.core;

namespace Interop
{
	[SupportsInheritance]
	public struct EditorCurveBinding : EditorCurveBinding.Interface, IUpCastable<EditorCurveBinding>
	{
		[Flags]
		public enum Flags
		{
			kNone = 0,
			kDiscrete = 1,
			kPPtr = 2,
			kSerializeReference = 4,
			kPhantom = 8,
			kUnknown = 0x10
		}

		public interface Interface : IUpCastable<EditorCurveBinding>
		{
		}

		public basic_string path;

		public basic_string attribute;

		[NativeTypeName("Unity::Type const *")]
		public unsafe Interop.Unity.Type* type;

		public PPtr<MonoScript> script;

		public Flags flags;

		unsafe ref EditorCurveBinding IUpCastable<EditorCurveBinding>.Cast()
		{
			return ref *(EditorCurveBinding*)null;
		}
	}
}
