Shader "Custom/NewSurfaceShader"
{
    Properties{
        _Color ("COLOR", Color) = (0,0,0,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Lambert
        
        sampler2D _MainTex;
    fixed4 _Color;

        struct Input {
            fixed2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = _Color.rgb;
            o.Alpha = _Color.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
