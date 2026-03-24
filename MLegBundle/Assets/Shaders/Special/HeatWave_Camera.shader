Shader "ULTRAKILL/HeatWave_Camera" {
	Properties {
		_MainTex ("Particle Texture", 2D) = "white" {}
		_NoiseTex ("Noise Texture", 3D) = "white" {}
		_DistortionAmount ("Distortion Amount", Range(0, 1)) = 0.1
		_Scale ("Distortion Scale", Float) = 0.5
		_Speed ("Distortion Speed", Float) = 0.5
		_AlphaMin ("Alpha Min Clip", Float) = 0
		_AlphaMax ("Alpha Max Clip", Float) = 1
		[Enum(UnityEngine.Rendering.CompareFunction)] _StencilComp ("Stencil Comparison", Float) = 3
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
	Fallback "Diffuse"
}