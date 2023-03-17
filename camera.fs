#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	//FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);

    //FragColor = vec4(10.0f, 0.5f, 4.2f, 1.0f);
    FragColor = vec4(29.4f, 0.1f, 0.6f, 1.0f);
}