#version 330 core
layout (location = 0) out vec4 FragColor;  
layout (location = 1) out vec3 OutNormal;
layout (location = 2) out float OutDepth;

in vec2 TexCoord;
in vec3 Normal;

uniform sampler2D texture_diffuse;

float near = 0.1; 
float far  = 10.0; 
  
float LinearizeDepth(float depth) 
{
    float z = depth * 2.0 - 1.0; // back to NDC 
    return (2.0 * near * far) / (far + near - z * (far - near));
}
  
void main()
{
    //Visualize depth
    float depth = LinearizeDepth(gl_FragCoord.z) / far; // divide by far for demonstration
    //FragColor = vec4(vec3(depth), 1.0);

    //Visualize normal
    //FragColor = vec4(Normal, 1.0);


    FragColor = texture(texture_diffuse, TexCoord);
    OutNormal = Normal;
    OutDepth = gl_FragCoord.z;
}