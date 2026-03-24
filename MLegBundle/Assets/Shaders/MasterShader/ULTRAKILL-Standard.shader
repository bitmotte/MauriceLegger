Shader "ULTRAKILL/Master" {
	Properties {
		[UltraCategory] _MainSettings ("Main Settings", Float) = 1
		_Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		[Toggle] _VertexColors ("Vertex Colors", Float) = 1
		[Toggle] _VertexLighting ("Vertex Lighting", Float) = 1
		_VertexWarpScale ("Vertex Warping Scalar", Range(0, 10)) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("Culling Mode", Float) = 2
		[KeywordEnum(On, Off, Transparent)] _Fog ("Fog Mode", Float) = 0
		[UltraHeader(Blending Options)] [Enum(Opaque,0,Cutout,1,Transparent,2,Advanced,3)] _BlendMode ("Blend Mode", Float) = 0
		[ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendOp)] _BlendOp ("Blend Op", Float) = 0
		[ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend ("Source Blend", Float) = 1
		[ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend ("Dest Blend", Float) = 0
		[UltraHeader(Outline Blending Options)] [ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendOp)] _BlendOp1 ("Blend Op Outline", Float) = 4
		[ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend1 ("Source Blend Outline", Float) = 4
		[EndUltraHeader] [ShowIf(_BlendMode(3))] [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend1 ("Dest Blend Outline", Float) = 1
		[ShowIf(_BlendMode(1, 2, 3))] _Opacity ("Opacity", Range(0, 1)) = 1
		[ShowIf(_BlendMode(2, 3))] [Toggle] _ZWrite ("ZWrite", Float) = 1
		[EndUltraHeader] [ShowRenderQueue] [ShowIf(_BlendMode(2, 3))] [Toggle] _ForceOutlineBehind ("Should Outline Objects Behind", Float) = 0
		[UltraCategory] _SurfaceSettings ("Surface Settings", Float) = 1
		[Enum(SurfaceType)] _SurfaceType ("Surface Type", Float) = 0
		_EnviroParticleColor ("Environment Particle Color", Vector) = (1,1,1,1)
		[UltraCategory] _StencilSettings ("Stencil Settings", Float) = 0
		_Stencil ("Stencil ID", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _StencilComp ("Stencil Comparison", Float) = 8
		[Enum(UnityEngine.Rendering.StencilOp)] _StencilOp ("Stencil Operation", Float) = 2
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		[UltraCategory] _ShaderFeatures ("Shader Features", Float) = 1
		[HelpBox] _HelpBox ("Hover over a Feature label for tooltips!", Float) = 0
		[KeywordToggle] ALLOW_MIPMAPS ("Name(Allow Mipmaps) Tooltip()", Float) = 0
		[KeywordToggle] ANIMATED_TEXTURE ("Name(Animated Texture) Tooltip(Scales and scrolls uv0 based on the provided frame count and framerate.)", Float) = 0
		[KeywordToggle] BILLBOARD ("Name(Billboard) Tooltip(Forces the object to look at the camera.)", Float) = 0
		[KeywordToggle] CAUSTICS ("Name(Caustics) Tooltip(Adds water caustics.)", Float) = 0
		[KeywordToggle] CUSTOM_LIGHTMAP ("Name(Custom Lightmap) Tooltip(Applies a baked lightmap texture.)", Float) = 0
		[KeywordToggle] CUSTOM_COLORS ("Name(Custom Colors) Tooltip(Controls weapon customization.)", Float) = 0
		[KeywordToggle] CYBER_GRIND ("Name(Cyber Grind) Tooltip(Controls the CyberGrind pulse visuals.)", Float) = 0
		[KeywordToggle] BLOOD_FILLER ("Name(Blood Filler) Tooltip(Used on 7-3 Blood Trees.\nFills upwards via scripting, using the noise texture to add detail.)", Float) = 0
		[KeywordToggle] BLOOD_ABSORBER ("Name(Blood Absorber) Tooltip(Used on 7-S.\nSupports receiving and washing of blood via scripting.)", Float) = 0
		[KeywordToggle] BURNING ("Name(Burning) Tooltip()", Float) = 0
		[KeywordToggle] DISTANCE_FADE ("Name(Distance Fade) Tooltip()", Float) = 0
		[KeywordToggle] ENEMY ("Name(Enemy) Tooltip()", Float) = 0
		[KeywordToggle] EMISSIVE ("Name(Emissive) Tooltip()", Float) = 0
		[KeywordToggle] FADEABLE_AMBIENT ("Name(Fadeable Ambient - Scripting Only) Tooltip()", Float) = 0
		[KeywordToggle] FRESNEL ("Name(Fresnel) Tooltip()", Float) = 0
		[KeywordToggle] LIMBO_WALLS ("Name(Limbo Walls) Tooltip()", Float) = 0
		[KeywordToggle] LIMBO_WATER_FADE ("Name(Limbo Water Fade) Tooltip(For Limbo, fade out the material when a player or enemy is intersecting the surface.)", Float) = 0
		[KeywordToggle] RADIANCE ("Name(Radiance) Tooltip()", Float) = 0
		[KeywordToggle] RAIN ("Name(Rain) Tooltip()", Float) = 0
		[KeywordToggle] REFLECTION ("Name(Reflection) Tooltip()", Float) = 0
		[KeywordToggle] SCROLLING ("Name(Scrolling) Tooltip()", Float) = 0
		[KeywordToggle] SPARKLES ("Name(Sparkles) Tooltip()", Float) = 0
		[KeywordToggle] TRANSMISSION ("Name( Transmission) Tooltip(For light passing through an object.)", Float) = 0
		[KeywordToggle] VERTEX_BLENDING ("Name(Vertex Blending) Tooltip(Red Channel blends between main texture/color and secondary texture/color.\nGreen Channel blends lighting contribution.)", Float) = 0
		[KeywordToggle] VERTEX_DISPLACEMENT ("Name(Vertex Displacement) Tooltip()", Float) = 0
		[Keyword(BILLBOARD)] _BillboardAxes ("Axes To Lock", Vector) = (0,0,0,0)
		[Keyword(BILLBOARD)] _DepthOffset ("Depth Offset Scalar", Float) = 1
		[Keyword(CAUSTICS)] [NoScaleOffset] _Cells ("Cells", 2D) = "white" {}
		[Keyword(CAUSTICS)] [NoScaleOffset] _Perlin ("Perlin", 2D) = "white" {}
		[Keyword(CAUSTICS)] _CausticColor ("Caustics Color", Vector) = (1,1,1,1)
		[Keyword(CAUSTICS)] _Scale ("World Scale", Float) = 1
		[Keyword(CAUSTICS)] _Falloff ("Mask Falloff", Float) = 1
		[Keyword(CAUSTICS)] _Speed ("Speed", Float) = 0.5
		[Keyword(CAUSTICS)] [Enum(Basic,0,Vertex Blended,1,Caustic Volumes,2)] _CausticMode ("Caustic Mode", Float) = 0
		[Keyword(CAUSTICS)] _CausticsDirection ("Direction", Vector) = (0,1,0,0)
		[Keyword(REFLECTION)] _ReflectionMask ("Reflection Mask", 2D) = "white" {}
		[Keyword(CUSTOM_COLORS, REFLECTION)] _CubeTex ("Cube Texture", Cube) = "_Skybox" {}
		[Keyword(CUSTOM_COLORS)] _IDTex ("ID Texture", 2D) = "white" {}
		[Keyword(CUSTOM_COLORS)] _CustomColor1 ("Color 1", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS)] _CustomColor2 ("Color 2", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS)] _CustomColor3 ("Color 3", Vector) = (1,1,1,1)
		[Keyword(CUSTOM_COLORS, REFLECTION)] [Enum(Replace,0,Add,1)] _CubeMode ("Cubemap Mode", Float) = 0
		[Keyword(CUSTOM_COLORS, REFLECTION)] _ReflectionStrength ("Reflection Strength", Float) = 1
		[Keyword(CUSTOM_COLORS)] _ReflectionFalloff ("Reflection Falloff", Float) = 1
		[Keyword(CUSTOM_LIGHTMAP)] _LightMapTex ("Light Map Texture", 2D) = "white" {}
		[Keyword(BLOOD_ABSORBER] [HideInInspector] _BloodTex ("BloodTex", 2D) = "black" {}
		[Keyword(BLOOD_FILLER)] _BloodNoiseTex ("Blood Noise Texture", 2D) = "white" {}
		[Keyword(BURNING)] _BurningTex ("Burning Texture", 2D) = "white" {}
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveColor ("Emissive Color", Vector) = (1,1,1,1)
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveTex ("Emissive Texture", 2D) = "white" {}
		[Keyword(EMISSIVE)] [Toggle] _EmissiveMask ("Use Emissive Mask (Color Alpha)", Float) = 0
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveIntensity ("Emissive Strength", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveSaturation ("Emissive Saturation", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] [Toggle] _UseAlbedoAsEmissive ("Use Albedo As Emissive", Float) = 1
		[Keyword(CYBER_GRIND, EMISSIVE)] [Toggle] _EmissiveReplaces ("Emissive Replaces Instead of Adding to Underlying Color", Float) = 0
		[Keyword(EMISSIVE)] [Toggle] _FakeHDR ("Fake HDR", Float) = 0
		[Keyword(EMISSIVE)] [ShowIf(_FakeHDR)] _HDRBoost ("HDR Boost", Float) = 0
		[Keyword(EMISSIVE)] _EmissiveToVertexColors ("Vertex Colors Emissive Tint", Float) = 0
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveFogStart ("Emissive Fog Start", Float) = 99999
		[Keyword(CYBER_GRIND, EMISSIVE)] _EmissiveFogEnd ("Emissive Fog End", Float) = 99999
		[Keyword(CYBER_GRIND)] _GradientFalloff ("Gradient Falloff", Float) = 1
		[Keyword(CYBER_GRIND)] _GradientScale ("Gradient Scale", Float) = 1
		[Keyword(CYBER_GRIND)] _GradientSpeed ("Gradient Speed", Float) = 1
		[Keyword(CYBER_GRIND)] [Toggle] _PCGamerMode ("PC Gamer Mode", Float) = 0
		[Keyword(CYBER_GRIND)] _RainbowDensity ("Rainbow Density", Float) = 1
		[Keyword(DISTANCE_FADE, LIMBO_WATER_FADE)] [Toggle] _UseSoftFade ("Use Soft Fade", Float) = 0
		[Keyword(DISTANCE_FADE, LIMBO_WATER_FADE)] _NearClip ("Near Clip", Float) = 0
		[Keyword(DISTANCE_FADE, LIMBO_WATER_FADE)] _FarClip ("Far Clip", Float) = 1
		[Keyword(DISTANCE_FADE, LIMBO_WATER_FADE)] _DitherTexture ("Dither Texture", 2D) = "grey" {}
		[Keyword(ENEMY)] _BlessedFalloff ("Blessed Falloff", Float) = 1
		[Keyword(ENEMY)] _BlessedStrength ("Blessed Strength", Float) = 1
		[Keyword(ENEMY)] _Blessedmoothness ("Blessed Normal Smoothness", Range(0, 1)) = 1
		[Keyword(FRESNEL)] _FresnelColor ("Fresnel Color", Vector) = (1,1,1,1)
		[Keyword(FRESNEL)] _FresnelStrength ("Fresnel Strength", Float) = 1
		[Keyword(LIMBO_WALLS)] _GlitchTex ("Glitch Texture", 2D) = "white" {}
		[Keyword(LIMBO_WALLS)] _ChromaticAberration ("Chromatic Aberration", Float) = 2
		[Keyword(LIMBO_WALLS)] _GlitchBlockStrength ("Glitch Block Strength", Float) = 0.1
		[Keyword(LIMBO_WALLS)] _GlitchBlockColor ("Glitch Block Color", Float) = 0.1
		[Keyword(LIMBO_WALLS)] _TextureWarpingOverride ("Texture Warping Override", Float) = 0.1
		[Keyword(LIMBO_WALLS)] [Toggle] _OffAxisPanelFeature ("Allow Broken Panels (Requires NoBatch script)", Float) = 0
		[Keyword(LIMBO_WALLS)] [KeywordEnum(None, Small, Large)] _GlitchMode ("GlitchMode", Float) = 0
		[Keyword(RAIN)] _RainDarkening ("Wet Darkening Color", Vector) = (1,1,1,1)
		[Keyword(RAIN)] _RainColor ("Rain Color", Vector) = (0.2,0.2,0.3,1)
		[Keyword(RAIN)] _RainDrops ("Rain Drops", 2D) = "white" {}
		[Keyword(RAIN)] _RainTrails ("Rain Trails", 2D) = "white" {}
		[Keyword(RAIN)] _RainSpeed ("Rain Speed", Float) = 2
		[Keyword(RAIN)] _RaindropsIntensity ("Raindrops Intensity", Float) = 1
		[Keyword(RAIN)] _RainScale ("Rain Scale", Float) = 1
		[Keyword(RAIN)] _WarpDetail ("Warp Detail", Float) = 1
		[Keyword(RAIN)] [Toggle] _LocalOffsetRain ("Use Local Space", Float) = 0
		[Keyword(RAIN)] [Toggle] _RainCeilingToggle ("Hide Ceiling Drops", Float) = 1
		[Keyword(REFLECTION)] _LightingContribution ("Lighting Contribution ", Float) = 0
		[Keyword(REFLECTION)] _ColorContribution ("Color Contribution", Float) = 0
		[Keyword(RADIANCE)] _BuffTex ("Buff Tex (RGB)", 2D) = "white" {}
		[Keyword(RADIANCE)] _InflateStrength ("Inflate Strength", Float) = 1
		[Keyword(SCROLLING)] _ScrollSpeed ("Custom Scroll Speed", Vector) = (0,0,0,0)
		[Keyword(SPARKLES)] [NoScaleOffset] _NoiseTex ("Noise", 2D) = "black" {}
		[Keyword(SPARKLES)] _SpecularStrength ("Reflection Strength", Float) = 1
		[Keyword(SPARKLES)] _Scattering ("Scattering", Float) = 0.25
		[Keyword(SPARKLES)] _Saturation ("Saturation", Float) = 1
		[Keyword(SPARKLES)] _NoiseScale ("UV Scale", Float) = 1
		[Keyword(SPARKLES)] _Sharpness ("Reflection Sharpness", Float) = 50
		[Keyword(SPARKLES)] _FresnelBoost ("Fresnel Boost", Float) = 1
		[Keyword(SPARKLES)] _ScatterinNearFade ("Near Fade", Float) = 0
		[Keyword(SPARKLES)] _ScatterinFarFade ("Far Fade", Float) = 200
		[Keyword(SPARKLES)] _FadeCurve ("Fade Gamma Curve", Float) = 1
		[Keyword(SPARKLES)] _SparkleSpeed ("Speed", Float) = 2
		[Keyword(TRANSMISSION)] _TransmissionColor ("Transmission Color", Vector) = (1,1,1,1)
		[Keyword(TRANSMISSION)] _TransmissionAmount ("Transmission Amount", Float) = 0
		[Keyword(TRANSMISSION)] [NoScaleOffset] _TransmissionMask ("Transmission Mask", 2D) = "white" {}
		[Keyword(VERTEX_BLENDING)] _BlendColor ("Secondary Color", Vector) = (1,1,1,1)
		[Keyword(VERTEX_BLENDING)] [NoScaleOffset] _BlendTex ("Secondary Texture", 2D) = "white" {}
		[Keyword(VERTEX_BLENDING)] [Enum(SurfaceType)] _SecondarySurfaceType ("Secondary Surface Type", Float) = 0
		[Keyword(VERTEX_BLENDING)] _SecondaryEnviroParticleColor ("Secondray Environment Particle Color", Vector) = (1,1,1,1)
		[Keyword(VERTEX_DISPLACEMENT)] [Enum(Texture,0,UV Coordinate,1,Vertex Color,2,UV Texture,3)] _VertexMode ("Vertex Displacement Mode", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0, 3))] [NoScaleOffset] _VertexNoiseTex ("Vertex Noise Texture Lookup", 2D) = "black" {}
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0, 1, 2))] _VertexNoiseScale ("Vertex Distortion Density", Range(0, 10)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0, 1, 2))] _VertexNoiseSpeed ("Vertex Distortion Speed", Range(0, 10)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(3))] _UVNoiseScale ("UV Noise Scale ", Vector) = (1,1,0,0)
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(3))] _UVNoiseSpeed ("UV Noise Speed", Vector) = (1,1,0,0)
		[Keyword(VERTEX_DISPLACEMENT)] _VertexNoiseAmplitude ("Vertex Distortion Amplitude", Range(0, 50)) = 1
		[Keyword(VERTEX_DISPLACEMENT)] _VertexScale ("Vertex Inflation Scale", Range(0, 1)) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0))] _FlowDirection ("Vertex Distortion Flow Direction (Normalized XYZ)", Vector) = (0,1,0,1)
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _ReverseFlow ("Reverse Flow", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _PreventClipping ("Prevent Clipping", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0, 2))] [Toggle] _VColStrength ("Green Channel Controls Strength", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_VertexMode(0))] [Toggle] _LocalOffset ("Use Local Space Offset", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [Toggle] _RecalculateNormals ("Recalculate Normals", Float) = 0
		[Keyword(VERTEX_DISPLACEMENT)] [ShowIf(_RecalculateNormals)] _NormalOffsetScale ("Normal Offset Scale", Float) = 1
		[HideInInspector] _ForceSecondary ("Force Secondary", Float) = 0
		[HideInInspector] _BatchingID ("Batching ID", Int) = 0
		[HideInInspector] _Outline ("Assist Outline", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	//CustomEditor "ULTRAShaderEditor"
}