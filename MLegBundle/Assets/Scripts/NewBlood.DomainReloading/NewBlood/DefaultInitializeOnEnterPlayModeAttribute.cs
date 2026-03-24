using System;
using System.Diagnostics;

namespace NewBlood
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DefaultInitializeOnEnterPlayModeAttribute : Attribute
	{
		public DefaultInitializeType InitializeType { get; }

		public object? Value { get; }

		public DefaultInitializeOnEnterPlayModeAttribute(DefaultInitializeType type = DefaultInitializeType.Default)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(bool value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(byte value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(sbyte value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(ushort value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(short value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(uint value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(int value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(ulong value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(long value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(float value)
		{
		}

		public DefaultInitializeOnEnterPlayModeAttribute(double value)
		{
		}
	}
}
