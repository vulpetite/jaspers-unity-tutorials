Shader "Graph/Point Surface" {
    SubShader {
        CGPROGRAM
        #pragma surface ConfigureSurface Standard fullforwardshadows
        #pragma target 3.0

        struct Input {
            float3 worldPos;
        };

        void ConfigureSurface (Input input,inout SurfaceOutputStandard surface) {}
        ENDCG
    }

    FallBack "Diffuse"
}
