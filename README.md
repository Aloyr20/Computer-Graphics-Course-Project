# Computer-Graphics-Course-Project
Intro to CG Course Project


Augie

<img width="735" height="493" alt="image" src="https://github.com/user-attachments/assets/5e0d7527-5bce-4908-aa1e-1dca285748d1" />

First I take the positional coordinates of the “pixels” which is the UVs. You then multiply them to make the coordinates bigger. You then divide them by the same number to keep the pixels enlarged but to fit them to the aspect ratio of the players screen. You then apply a simple noise output to provide pixelation.

<img width="714" height="500" alt="image" src="https://github.com/user-attachments/assets/b0030629-d367-4326-86b6-49c643f79d17" />

First I take the UV and apply it to the dither function and the noise function. I then subtract it by 0.52 on the x and 0.52 on the y. This gave me the desired output for the effect. I then multiplied the value by the dither effect float to actual store the strength of the effect. Then add it with the noise effect to create the base dithering. I then multiply it by color res to get a set color value output and number of pixels. I then add it by the same values as before to keep the strengthening consistent and then floor that value to get a round number for consistency. Lastly I divide it by the color Res to set the color/pixel ratio to then be outputted to the display.

Shuaiyan Chen

<img width="1197" height="548" alt="image" src="https://github.com/user-attachments/assets/45f119d7-fda4-4ac6-b7a2-ef2f1baf7ce4" />
<img width="1214" height="607" alt="image" src="https://github.com/user-attachments/assets/7a862cbf-c148-4ddb-8d7d-528f39cbfd6a" />

The XRay Shader uses transparent rendering and Emission to allow objects to remain highlighted even when occluded, simulating a perspective scan visual effect. First, the shader sets the Surface Type to Transparent, putting the object into the transparent rendering queue so it's drawn after all opaque objects. The Alpha channel controls the transparency of the main body, making the model appear semi-transparent. Then, in the lighting calculation, the shader uses the dot product of the Normal Vector and View Direction to determine if a pixel is facing away from the camera. A smaller dot product value indicates that the pixel is more towards the back of the object. We then perform a One Minus inversion on this result, resulting in a mask that is brighter on the back and darker on the front. This mask serves as input to Emission, creating a noticeable highlight effect on the parts of the model facing away from the camera. Finally, setting the Depth Test to Always ensures that pixels in this shader unconditionally pass the depth test and are not culled by foreground objects.

<img width="1206" height="559" alt="image" src="https://github.com/user-attachments/assets/32f7ccfb-fabd-4b57-9ee7-b114254cc000" />

The Dissolve Shader works by using a random noise map to determine where objects are preserved and where they disappear, and then using an adjustable "ClipRate" to control the dissolving process. For example, if you have a black and white speckle image, and I give you a number, say 0.3, you'll erase all areas darker than 0.3 in the noise map. If I increase the number to 0.6, you'll erase even more areas. This number is the ClipRate, so the larger it is, the more the object dissolves. Before the dissolving effect begins, the main texture is sampled to obtain the model's color, and then parameters such as MainColor and ColorTin are used to adjust the hue to match the desired style. The White Balance node performs color temperature correction, similar to the warm or cool tones in a camera; a higher ColorTemp value results in a warmer color, and a lower value results in a cooler color. These operations simply make the object's base color look more natural or better suited to the scene's atmosphere. Afterwards, Simple Noise generates a random noise map with varying brightness. Brighter areas may be dissolved later, while darker areas will disappear first. The ClipRate acts like a sliding threshold. The shader continuously compares the noise value with the ClipRate. If the noise is smaller than the ClipRate, the pixels there are considered dissolved; if it's larger, they are preserved. As the ClipRate value gradually increases from 0 to 1, the entire model is gradually "swallowed" according to the shape of the noise. This is the dissolution effect we see. To make the dissolution more obvious, a bright color is added to the edges that are just dissolved. The shader detects areas that are right near the threshold and brightens these edges using the dissolution color. This makes it visually appear as if the model is burning or dissipating energy, rather than simply disappearing transparently.

<img width="603" height="420" alt="image" src="https://github.com/user-attachments/assets/ca248dcc-48e5-4a53-b597-fcf4ece0b9d0" />

The core idea of ​​this lava shader is as follows: First, to make the lava appear to be continuously flowing, the shader uses a Time node to provide an ever-increasing time value, which is then multiplied by the SurfaceSpeed ​​parameter to obtain an adjustable offset. This offset is input into the Offset of Tiling And Offset, causing the UV coordinates of the Lava texture to slide in one direction over time, creating the effect of flowing lava. Then, a Normal Map is used to simulate the unevenness of the lava surface. The Normal Map itself determines how light reflects off the material surface, and the NormalIntensity parameter multiplies the normals, thus enhancing or diminishing the unevenness. A higher NormalIntensity makes the surface rougher and more undulating, while a lower value makes the surface smoother, closer to a liquid state. Finally, the processed Normal Map is input into the material's Normal channel, giving the lava a realistic sense of volume and surface texture under lighting. Then, in terms of color representation, Lava color texture is used to provide the color display of lava. Then, LavaTexture is multiplyed with MainColor. This final color output is sent to BaseColor to render the main color visual of the lava. 

Luke Boctor

<img width="420" height="444" alt="image" src="https://github.com/user-attachments/assets/8c1257be-33ec-4f40-a313-99f45183c2fe" />

Uses the decal projector component
Rounds the angle of the spell projectile to the nearest 90 degrees on contact
Places decal with that rotation


<img width="301" height="324" alt="image" src="https://github.com/user-attachments/assets/7e54a73c-38c5-4fec-8880-690e3c7b9c17" />

<img width="325" height="323" alt="image" src="https://github.com/user-attachments/assets/f79aae34-4752-4ec0-988e-92a9fdfd9220" />

<img width="296" height="320" alt="image" src="https://github.com/user-attachments/assets/201a6539-da37-4d04-8159-b4388c04741a" />

Uses stencil shader
Samples cubemap with non-inverse view direction for nicer view

<img width="615" height="585" alt="image" src="https://github.com/user-attachments/assets/3549d469-8469-4cce-863d-16b569303945" />

Scrolling texture + moves player up
F1 to toggle





