/*
                                                                                                                            
88b           d88                      88 88    ad88 88                               88                                    
888b         d888                      88 ""   d8"   ""                         ,d    ""                                    
88`8b       d8'88                      88      88                               88                                          
88 `8b     d8' 88  ,adPPYba,   ,adPPYb,88 88 MM88MMM 88  ,adPPYba, ,adPPYYba, MM88MMM 88  ,adPPYba,  8b,dPPYba,  ,adPPYba,  
88  `8b   d8'  88 a8"     "8a a8"    `Y88 88   88    88 a8"     "" ""     `Y8   88    88 a8"     "8a 88P'   `"8a I8[    ""  
88   `8b d8'   88 8b       d8 8b       88 88   88    88 8b         ,adPPPPP88   88    88 8b       d8 88       88  `"Y8ba,   
88    `888'    88 "8a,   ,a8" "8a,   ,d88 88   88    88 "8a,   ,aa 88,    ,88   88,   88 "8a,   ,a8" 88       88 aa    ]8I  
88     `8'     88  `"YbbdP"'   `"8bbdP"Y8 88   88    88  `"Ybbd8"' `"8bbdP"Y8   "Y888 88  `"YbbdP"'  88       88 `"YbbdP"'  
                                                                                                                            


1.) Changed out textures/materials, specifically lava mat in order to make sure there were no premade materials, shaders, or prefabs.
2.) Modified directional light intensity and color to cast a more dark-red tone overall.
3.) Created complex 3D object for player model and reimplemented player controller and camera to match up. Modified run speed, jump speed, etc.
4.) Made a fog with a pinkish hue.
5.) Added and modified skybox to be bigger, bolder, and contain red and orange hues.
6.) Deleted 2 of the finish zones in order to make one into prefab. Created 2 variants and placed instances of the prefab with different colors.
7.) Added fire particle system w/ custom created shader that has custom flame material to prefab. Edited many parameters including duration, size, speed, emission, shape, color over lifetime, etc. 
    Adjusted color for each finish zone to reflect the color of said zone.
8.) Painted in multiple new textures to smooth out the look of the terrain, including a new lava texture that adds dimension to the volcano and around some rocky terrain.
9.) Raised, lowered, and arranged terrain to create more obvious borders and walls. Made slight tweaks to terrain that player jumps on to make some areas a little easier.
10.) Extendded Hazard detector radious to catch if player goes out of bounds.
11.) Added a screen snow particle effect.... or is it ash?
12.) Added FPS Limiter script set to 60 FPS in order to optimize performance as when it was originally trying to hit 350+ FPS, the animation of the doughnut was slow and choppy. Also adjusted some
     texture/material properties such as reflections and reduced resolution in attempt to further optimize performance.
13.) 

Need to haves:
- extra obstacles
    . barriers that respawn player

Nice to haves:
- Tophat on Player
- destructible barriers
- ability to throw snowballs that destroy barriers
*/