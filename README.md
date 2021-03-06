# SelfKickPlugin
SelfKickPlugin provides commands for listing the currently loaded plugins.

# Setup
1. Get the [latest](/Arthri/SelfKickPlugin/releases/latest) release
2. Place the `.zip` file in the `ServerPlugins` folder
3. Unzip it

# Usage
1. Start server
2. Get the `selfkickplugin.selfkick` permission
3. `/skick` or `/selfkick` or `/kickself`

# Development

## Setup Dependencies
- Restore NuGet packages to get OTAPI and Newtonsoft.JSON
- Get the [latest](/Pryaxis/TShock/releases/latest) TShock release
- Take `TerrariaServer.exe` and `TShockAPI.dll` from the release and put it in `lib/`

## Compile
- Open `SelfKickPlugin.sln`
- Build Solution, Alt + B + B, or Ctrl + Shift + B

## Get Compiled
- Navigate to `src/SelfKickPlugin/bin/{BUILD_CONFIGURATION}/` where `{BUILD_CONFIGURATION}` is either Debug or Release
- Copy `SelfKickPlugin.dll`
- Done
