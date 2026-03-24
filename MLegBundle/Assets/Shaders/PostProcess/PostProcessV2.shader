Shader "ULTRAKILL/PostProcessV2" {
	Properties {
		[NoScaleOffset] _MainTex ("Main Texture", 2D) = "white" {}
		[NoScaleOffset] _HudTex ("Hud Texture", 2D) = "white" {}
		[NoScaleOffset] _OutlineTex ("Outline Texture", 2D) = "black" {}
		[NoScaleOffset] _Dither ("Dither Texture", 2D) = "grey" {}
		[NoScaleOffset] _VignetteTex ("Dither Texture", 2D) = "grey" {}
		[Header(Underwater Controls)] [NoScaleOffset] _NoiseTex ("Tiling Noise", 2D) = "grey" {}
		_UnderWaterScale ("Underwater Warp Scaling", Float) = 1
		_UnderWaterStrength ("Underwater Warp Strength", Float) = 1
		_UnderWaterSpeed ("Underwater Warp Speed", Float) = 1
		_JFADistance ("JFA Distance", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}