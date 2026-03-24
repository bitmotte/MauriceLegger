using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PostProcessV2_Handler : MonoSingleton<PostProcessV2_Handler>
{
	public Material postProcessV2_VSRM;

	public Material screenNormal;

	public Material heatWaveMat;

	private CommandBuffer heatCB;

	public Shader outlinePx;

	public Shader outlinePx_SimpleTest;

	private Material outlineMat;

	private CommandBuffer outlineCB;

	[Space(10f)]
	public bool useHeightFog;

	public Texture oilTex;

	public Texture sandTex;

	public Texture buffTex;

	public Texture ditherTexture;

	public Texture vignetteTexture;

	public int distance;

	public Camera mainCam;

	public Camera hudCam;

	public Camera virtualCam;

	public RenderBuffer[] buffers;

	public RenderTexture mainTex;

	public RenderTexture reusableBufferA;

	[HideInInspector]
	public RenderTexture reusableBufferB;

	public RenderTexture depthBuffer;

	public RenderTexture viewNormal;

	public RenderTexture portalMask;

	private int width;

	private int height;

	private int lastWidth;

	private int lastHeight;

	private bool reinitializeTextures;

	private bool mainCameraOnly;

	[HideInInspector]
	public float downscaleResolution;

	public Texture CurrentTexture;

	public Texture CurrentMapPaletteOverride;

	public Material radiantBuff;

	private OptionsManager oman;

	public bool debugFooled;

	[SerializeField]
	private ComputeShader paletteCompute;

	[SerializeField]
	private Shader paletteCalc;

	private bool isGLCore;

	private float realDist;

	public Action<bool> onReinitialize;

	public bool usedComputeShadersAtStart;

	private CommandBuffer bloodOilCB;

	private CommandBuffer mainPostProcess;

	private Material outlinePx_SimpleTestMat;

	private static Matrix4x4 identityMatrix;

	private SpaceSkybox spaceSky;

	private List<LimboSkybox> limboSkyboxes;

	private CommandBuffer clearOutlines;

	private void OnValidate()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPrefChanged(string key, object value)
	{
	}

	private void SetPixelization(int option)
	{
	}

	private void Start()
	{
	}

	public void DeathEffect(bool isDead)
	{
	}

	public void WickedEffect(bool doWicked)
	{
	}

	public void Vignette(bool doVignette)
	{
	}

	public void Fooled(bool doEnable)
	{
	}

	public void ColorPalette(bool stuff)
	{
	}

	public void ApplyUserColorPalette(Texture tex)
	{
	}

	public void ApplyMapColorPalette(Texture tex)
	{
	}

	private void ReinitializeCameras()
	{
	}

	private void SetupRTs()
	{
	}

	public static Vector4 GetProjectionParams(Camera cam)
	{
		return default(Vector4);
	}

	public static Vector4 ZBufferParams(Camera cam)
	{
		return default(Vector4);
	}

	private void ReleaseTextures()
	{
	}

	public void HeatWaves()
	{
	}

	public void SetupOutlines(bool forceOnePixelOutline = false)
	{
	}

	public void ChangeCamera(bool hudless)
	{
	}

	public void OnPreRenderCallback(Camera cam)
	{
	}

	public void RenderSpaceSky(Camera cam)
	{
	}

	public void RenderLimboSkyboxes(Camera cam)
	{
	}

	public Matrix4x4 GetInverseVP_NonOblique(Camera cam)
	{
		return default(Matrix4x4);
	}

	public static void TryDestroyTexture(RenderTexture rt, bool destroyImmediate = false)
	{
	}

	private void OnDestroy()
	{
	}

	internal void AddLimboSkybox(LimboSkybox limboSkybox)
	{
	}

	internal void AddSpaceSkybox(SpaceSkybox spaceSkybox)
	{
	}

	internal void RenderSkyboxes()
	{
	}
}
