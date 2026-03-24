namespace Interop
{
	public struct RTTI
	{
		public struct DerivedFromInfo
		{
			[NativeTypeName("RuntimeTypeIndex")]
			public uint typeIndex;

			public uint descendantCount;
		}

		public unsafe RTTI* @base;

		public unsafe delegate* unmanaged[Stdcall]<MemLabelId, ObjectCreationMode, Object*> factory;

		[NativeTypeName("char const *")]
		public unsafe sbyte* className;

		[NativeTypeName("char const *")]
		public unsafe sbyte* classNamespace;

		[NativeTypeName("char const *")]
		public unsafe sbyte* module;

		[NativeTypeName("PersistentTypeID")]
		public int persistentTypeID;

		public int size;

		public DerivedFromInfo derivedFromInfo;

		[NativeTypeName("bool")]
		public byte isAbstract;

		[NativeTypeName("bool")]
		public byte isSealed;

		[NativeTypeName("bool")]
		public byte isEditorOnly;

		[NativeTypeName("bool")]
		public byte isStripped;

		[NativeTypeName("ConstVariantRef const *")]
		public unsafe ConstVariantRef* attributes;

		public nuint attributeCount;
	}
}
