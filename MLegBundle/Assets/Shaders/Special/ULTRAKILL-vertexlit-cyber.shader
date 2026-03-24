Shader "psx/vertexlit/cyber" {
	Properties {
		[Header(Main)] [Space] _Color ("Color", Vector) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_VertexWarpScale ("Vertex Warping Scalar", Range(0, 10)) = 1
		[Toggle] _Outline ("Assist Outline", Float) = 0
		[Header(Emissive)] [Space] _EmissiveTex ("Emissive Mask Texture (G)", 2D) = "black" {}
		[MaterialToggle] _UseAlbedoAsEmissive ("Use Base Texture as Emissve Color", Float) = 0
		[MaterialToggle] _EmissiveReplaces ("Emissive Replaces Instead of Adding to Underlying Color", Float) = 0
		_EmissiveColor ("Emissive Color (RGB)", Vector) = (0,0,0,0)
		_EmissiveIntensity ("Emissive Strength", Float) = 1
		[Header(Special Pulsate Controls)] [Space] [MaterialToggle] _PCGamerMode ("Engage Rainbow Mode", Float) = 0
		[IntRange] _RainbowDensity ("RainbowDensity", Range(0, 200)) = 1
		_GradientScale ("Gradient Scale", Range(0, 2)) = 1
		_GradientFalloff ("Gradient Falloff", Range(0, 10)) = 5
		_GradientSpeed ("Gradient Speed", Range(0, 50)) = 5
		_WorldOffset ("World Center Offset", Vector) = (0,0,0,1)
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