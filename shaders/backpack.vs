#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTexCoords;
  
//out vec3 ourColor; // output a color to the fragment shader
out vec2 TexCoord;
out vec3 Normal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    TexCoord = aTexCoords;    
    gl_Position = projection * view * model * vec4(aPos, 1.0);
    Normal = aNormal;
}   