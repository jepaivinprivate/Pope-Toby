Shader "Custom/NoisyDiffuse" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		 	float3 worldPos;
		};

		float rand(float2 co)
		{
    		return frac(sin(dot(co.xy ,float2(12.9898,78.233))) * 43758.5453);
		}

		void surf (Input IN, inout SurfaceOutput o) {
			//half4 c = tex2D (_MainTex, IN.uv_MainTex);
			float4 c;
			float1 s = clamp(IN.uv_MainTex.x,0,1);// 0.5f - IN.UV_MainTex.y + 0.5f,0,1);
			c.r =  1-s;
			c.g = (1-s)/2 + rand(IN.worldPos.y)*0.21f;
			c.b = s;
			
			o.Albedo = c.rgb;
			o.Alpha = 0.66f;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
