# summer-23-unity

Video game demo built in 2023 in the Unity Engine

## Initial Setup (Mac)

- Git
    - In terminal, enter command `brew install git`
-  Unity
   - Download [Unity Hub](https://unity.com/download).
   - Run it, and install the latest version of Unity
   - Projects > Open > Add project from disk
   - Add project folder from local repo
- Blender
   - Download [Blender](https://www.blender.org/download/).

## Build

- Building is simple in Unity: File > Build and Run
- Builds can also be retrieved from this repo under Actions.
    - Builds come zipped from GitHub, so extract.
    - OS X build will not have proper permissions, so run the following in terminal:      
      ```      
      cd Downloads/    (or wherever you put the app)
      chmod -R 777 [applicationName].app      
      ```     
    - This gives the app the execute permission, which is off by default.
      
## Docs

Additional docs on how this game was created can be found [here](docs/README.md). 
