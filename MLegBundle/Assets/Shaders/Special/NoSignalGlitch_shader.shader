Shader "Unlit/NoSignalGlitch" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_GlitchTex ("Glitch Texture", 2D) = "white" {}
		_FuzzStrength ("Fuzz Strength", Range(0, 1)) = 0
		_SpikeStrength ("Spike Strength", Range(0, 1)) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 8
		[Enum(UnityEngine.Rendering.BlendMode)] _Src ("Source Blend", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _Dest ("Dest Blend", Float) = 10
		[Enum(UnityEngine.Rendering.BlendMode)] _SrcA ("Alpha Source Blend", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _DestA ("Alpha Dest Blend", Float) = 10
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
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