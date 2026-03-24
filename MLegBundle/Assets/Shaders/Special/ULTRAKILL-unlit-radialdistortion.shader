Shader "psx/unlit/radialdistortion" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_VertexWarpScale ("Vertex Warping Scalar", Range(0, 10)) = 1
		_VertexNoise ("Vertex Noise Texture Lookup", 2D) = "black" {}
		_VertexNoiseScale ("Vertex Distortion Density", Range(0, 10)) = 1
		_VertexNoiseSpeed ("Vertex Distortion Speed", Range(0, 10)) = 1
		_VertexNoiseAmplitude ("Vertex Distortion Amplitude", Range(0, 10)) = 1
		_VertexScale ("Vertex Inflation Scale", Range(0, 1)) = 0
		_FlowDirection ("Vertex Distortion Flow Direction (Normalized XYZ)", Vector) = (0,1,0,1)
		[Toggle] _Outline ("Assist Outline", Float) = 0
		_ScrollMainTextureX ("Scroll MainTex X", Float) = 0
		_ScrollMainTextureY ("Scroll MainTex Y", Float) = 0
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
}