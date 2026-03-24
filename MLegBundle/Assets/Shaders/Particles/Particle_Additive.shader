Shader "ULTRAKILL/Particles/Additive" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_EmissionColor ("Emission Color", Vector) = (0,0,0,1)
		_Strength ("Strength Multiplier", Float) = 1
		_MainTex ("Texture", 2D) = "white" {}
		[Toggle] _ShouldForceOutlines ("Should Outline Objects Behind", Float) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 2
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