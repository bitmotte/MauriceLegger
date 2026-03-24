using UnityEngine;

public class VirtualAudioOutput : MonoBehaviour
{
	private int _updateIndex;

	public virtual Vector3 GetOutputPosition(AudioListener mainListener, VirtualAudioListener listener, Vector3 position)
	{
		return default(Vector3);
	}

	public void UpdateCachedValues(int updateIndex)
	{
	}

	protected virtual void UpdateCachedValuesCore()
	{
	}
}
