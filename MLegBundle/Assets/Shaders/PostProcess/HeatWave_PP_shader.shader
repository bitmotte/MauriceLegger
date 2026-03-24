Shader "Hidden/HeatWave_PP" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_NoiseTex ("Noise Texture", 3D) = "white" {}
		_DistortionAmount ("Distortion Amount", Range(0, 1)) = 0.1
		_Scale ("Distortion Scale", Float) = 0.5
		_Speed ("Distortion Speed", Float) = 0.5
		_Opacity ("Opacity", Float) = 0.5
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