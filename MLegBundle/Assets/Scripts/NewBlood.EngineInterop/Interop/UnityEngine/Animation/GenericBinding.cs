namespace Interop.UnityEngine.Animation
{
	public struct GenericBinding
	{
		[NativeTypeName("BindingHash")]
		public uint path;

		[NativeTypeName("BindingHash")]
		public uint attribute;

		public PPtr<Object> script;

		[NativeTypeName("PersistentTypeID")]
		public int typeID;

		public byte customType;

		public byte isPPtrCurve;

		public byte isIntCurve;

		public byte isSerializeReferenceCurve;
	}
}
