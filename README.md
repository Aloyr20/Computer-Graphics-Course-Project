# Computer-Graphics-Course-Project
Intro to CG Course Project

The Group members:
Augie

Shuaiyan Chen

Luke Boctor




<img width="1197" height="548" alt="image" src="https://github.com/user-attachments/assets/45f119d7-fda4-4ac6-b7a2-ef2f1baf7ce4" />
<img width="1214" height="607" alt="image" src="https://github.com/user-attachments/assets/7a862cbf-c148-4ddb-8d7d-528f39cbfd6a" />

The XRay Shader uses transparent rendering and Emission to allow objects to remain highlighted even when occluded, simulating a perspective scan visual effect. First, the shader sets the Surface Type to Transparent, putting the object into the transparent rendering queue so it's drawn after all opaque objects. The Alpha channel controls the transparency of the main body, making the model appear semi-transparent. Then, in the lighting calculation, the shader uses the dot product of the Normal Vector and View Direction to determine if a pixel is facing away from the camera. A smaller dot product value indicates that the pixel is more towards the back of the object. We then perform a One Minus inversion on this result, resulting in a mask that is brighter on the back and darker on the front. This mask serves as input to Emission, creating a noticeable highlight effect on the parts of the model facing away from the camera. Finally, setting the Depth Test to Always ensures that pixels in this shader unconditionally pass the depth test and are not culled by foreground objects.

<img width="1206" height="559" alt="image" src="https://github.com/user-attachments/assets/32f7ccfb-fabd-4b57-9ee7-b114254cc000" />

The Dissolve Shader works by using a random noise map to determine where objects are preserved and where they disappear, and then using an adjustable "ClipRate" to control the dissolving process. For example, if you have a black and white speckle image, and I give you a number, say 0.3, you'll erase all areas darker than 0.3 in the noise map. If I increase the number to 0.6, you'll erase even more areas. This number is the ClipRate, so the larger it is, the more the object dissolves. Before the dissolving effect begins, the main texture is sampled to obtain the model's color, and then parameters such as MainColor and ColorTin are used to adjust the hue to match the desired style. The White Balance node performs color temperature correction, similar to the warm or cool tones in a camera; a higher ColorTemp value results in a warmer color, and a lower value results in a cooler color. These operations simply make the object's base color look more natural or better suited to the scene's atmosphere. Afterwards, Simple Noise generates a random noise map with varying brightness. Brighter areas may be dissolved later, while darker areas will disappear first. The ClipRate acts like a sliding threshold. The shader continuously compares the noise value with the ClipRate. If the noise is smaller than the ClipRate, the pixels there are considered dissolved; if it's larger, they are preserved. As the ClipRate value gradually increases from 0 to 1, the entire model is gradually "swallowed" according to the shape of the noise. This is the dissolution effect we see. To make the dissolution more obvious, a bright color is added to the edges that are just dissolved. The shader detects areas that are right near the threshold and brightens these edges using the dissolution color. This makes it visually appear as if the model is burning or dissipating energy, rather than simply disappearing transparently.

<img width="603" height="420" alt="image" src="https://github.com/user-attachments/assets/ca248dcc-48e5-4a53-b597-fcf4ece0b9d0" />

The core idea of ​​this lava shader is as follows: First, to make the lava appear to be continuously flowing, the shader uses a Time node to provide an ever-increasing time value, which is then multiplied by the SurfaceSpeed ​​parameter to obtain an adjustable offset. This offset is input into the Offset of Tiling And Offset, causing the UV coordinates of the Lava texture to slide in one direction over time, creating the effect of flowing lava. Then, a Normal Map is used to simulate the unevenness of the lava surface. The Normal Map itself determines how light reflects off the material surface, and the NormalIntensity parameter multiplies the normals, thus enhancing or diminishing the unevenness. A higher NormalIntensity makes the surface rougher and more undulating, while a lower value makes the surface smoother, closer to a liquid state. Finally, the processed Normal Map is input into the material's Normal channel, giving the lava a realistic sense of volume and surface texture under lighting. Then, in terms of color representation, Lava color texture is used to provide the color display of lava. Then, LavaTexture is multiplyed with MainColor. This final color output is sent to BaseColor to render the main color visual of the lava. 








