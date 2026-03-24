Shader "ULTRAKILL/CloudySky" {
	Properties {
		_AmbientColor ("Ambient Cloud Color", Vector) = (0.1,0.3,0.5,0)
		_AmbientStrength ("Ambient Cloud Strength", Float) = 1
		_LightStrength ("Light Intensity", Float) = 1
		_LightColor ("Light Color", Vector) = (1,0.5,0.25,0)
		_LightDir ("Light Direction", Vector) = (1,0,0,0)
		_CloudTex ("Cloud Texture", 2D) = "white" {}
		[NoScaleOffset] _CloudNormals ("Cloud Normals", 2D) = "normal" {}
		_CloudHeight ("Cloud Height", Float) = 1
		_SkyColor ("Sky Color", Vector) = (1,1,1,1)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
}