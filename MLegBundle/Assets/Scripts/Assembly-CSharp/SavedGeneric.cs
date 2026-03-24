using System;
using Newtonsoft.Json;

[Serializable]
public class SavedGeneric
{
	[NonSerialized]
	public SpawnableObject Spawnable;

	public string ObjectIdentifier;

	public SavedVector3 Position;

	public SavedQuaternion Rotation;

	public SavedVector3 Scale;

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public SavedAlterData[] Data;

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool DisallowManipulation;

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool DisallowFreezing;
}
