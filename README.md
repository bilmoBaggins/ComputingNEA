# Projectile Motion Calculator

A Unity application that calculates and displays projectile-motion values from a launch configuration.

## Requirements

- Unity `2022.3.35f1`
- TextMesh Pro, included through the Unity Package Manager

## Run the Project

1. Open the project folder in Unity Hub.
2. Use Unity `2022.3.35f1` when prompted.
3. Open the `NEA` scene in `Assets/Scenes`.
4. Select Play in the Unity Editor.

## Inputs

The `ProjectileMotion` component uses these public values:

| Value | Meaning | Default |
| --- | --- | --- |
| `u` | Initial velocity | `20` |
| `s` | Distance travelled | `1` |
| `thetaDegrees` | Launch angle from the horizontal, in degrees | `30` |
| `h` | Elevation | `0` |

Gravity is set to `-9.81 m/s^2`.

## Outputs

The scene displays the calculated vertical velocity, horizontal velocity, time, final velocity, and maximum height using TextMesh Pro UI elements.

## Project Structure

```text
Assets/
  Scenes/NEA.unity             Main Unity scene
  Scripts/ProjectileMotion.cs  Projectile-motion calculations and UI updates
Packages/                      Unity package configuration
ProjectSettings/               Unity project settings
```

## Version Control

Unity-generated folders such as `Library`, `Temp`, `Logs`, `obj`, and `UserSettings` are ignored by Git. Commit changes to `Assets`, `Packages`, `ProjectSettings`, and source documentation.