#version 330 core
layout (location = 0) out vec4 FragColor;
layout (location = 1) out vec3 OutNormal;
layout (location = 2) out float OutDepth;

in vec2 TexCoords;

uniform sampler2D texture1;

void main()
{    
    FragColor = texture(texture1, TexCoords);
    OutNormal = vec3(1);
    OutDepth = gl_FragCoord.z;
}