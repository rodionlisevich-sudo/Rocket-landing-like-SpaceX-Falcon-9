# Rocket-landing-like-SpaceX-Falcon-9
How it works:
The rocket knows where the platform is and tilts using the thrust vector towards the platform, taking into account the distance and speed along the X and Z coordinates. When the height is less than 42, the rocket deflects the engine in the other direction to level off. The rocket has settings for engine rotation, thrust force, and engine rotation speed.The platform appears at random coordinates.
Scripts:
There are only four scripts: CameraMove.cs, EngineLandingThrust.cs, GameManager.cs, LandingPlatformRandomTransform.cs
CameraMove.cs controls the camera with the w,a,s,d,q,e keys.
EngineLandingThrust.cs slowly lands and guides the rocket onto the platform.
GameManager.cs restarts the game with the r key.
LandingPlatformRandomTransform.cs teleports the platform to random coordinates.
What happened:
In reality, things don't work very well because the rocket often falls on its side or doesn't land on the platform at all, but about 50% of landings are successful.
What else needs to be done:
The rocket should land in the center of the platform 100% of the time, the rocket should not fall on its side, the rocket should level off at low altitude in a true manner and not by using an "inversion if low".
