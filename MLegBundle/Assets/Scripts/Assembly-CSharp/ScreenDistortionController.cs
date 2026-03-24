using System.Collections.Generic;

public class ScreenDistortionController : MonoSingleton<ScreenDistortionController>
{
	public List<ScreenDistortionField> fields;

	private PostProcessV2_Handler pp;

	private int lastCount;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
