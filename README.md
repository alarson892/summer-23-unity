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
- Builds can also be found [here](https://github.com/alarson892/summer-23-unity/actions).
    - Builds come zipped from GitHub, so you'll need to download, extract, set permissions, then execute.
    - Below are the commands to download and run the game in MacOS via the terminal:      
      ```
      # Download a recent build from here: https://github.com/alarson892/summer-23-unity/actions
      
      # cd to wherever your dowloads are
      cd Downloads/

      # upzip the archive
      unzip Build-StandaloneOSX.zip

      # make the binary executable
      chmod +x StandaloneOSX.app/Contents/MacOS/summer-23-unity

      # launch the game
      # NOTE: the first time to launch, you will have to go into System Prefs -> Privacy & Security and trust the app
      # This means you'll end up running open command below twice.
      open StandaloneOSX.app
      
      ```
      
## Docs

Additional docs on how this game was created can be found [here](docs/README.md). 
