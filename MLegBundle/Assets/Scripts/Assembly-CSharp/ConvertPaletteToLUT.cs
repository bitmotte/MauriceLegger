using UnityEngine;

[ConfigureSingleton(SingletonFlags.PersistAutoInstance)]
public class ConvertPaletteToLUT : MonoSingleton<ConvertPaletteToLUT>
{
	public RenderTexture processedLUT;

	public RenderTexture lastLUT;

	public Texture2D lastPalette;

	private Material fallbackMaterial;

	public void ApplyLastPalette()
	{
	}

	public void ConvertPalette(Texture2D inputPalette, ComputeShader paletteCompute, Shader paletteCalc)
	{
	}
}
