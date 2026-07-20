# Bobo Bay Plugin Template

Modding template for [Bobo Bay](https://store.steampowered.com/app/1889810/Bobo_Bay/), powered by [BepInEx 5](https://github.com/BepInEx/BepInEx/tree/v5-lts).

## Features

This template is designed to work out-of-the-box: that means you can click `Build` and the project will just work.

- Automatically detects your game installation
- Includes several common references
- Installs your plugin on build
- Assets in `Assets` folder get copied to mod folder
- Assets in `Resources` folder get embedded in assembly

## Requirements

- [Bobo Bay](https://store.steampowered.com/app/1889810/Bobo_Bay/)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or [newer](https://dotnet.microsoft.com/en-us/download)
- .NET IDE of choice
  - ⭐ [**Rider**](https://www.jetbrains.com/rider/)
  - ⭐ [**Visual Studio Community 2026**](https://visualstudio.microsoft.com/vs/community/)
  - [Visual Studio Code](https://code.visualstudio.com/) with [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)

> [!NOTE]
> **Using [Visual Studio Community 2026](https://visualstudio.microsoft.com/vs/community/)?**
>
> The **.NET Desktop Development** workload automatically includes the latest **.NET SDK**.

## Getting Started

### Installing the template

Installing the templates is as easy as running the following command:

```
dotnet new install BoboBayPluginTemplate --nuget-source https://nuget.aethar.net/v3/index.json
```

This will result in the following being installed:

| Template Name   | Short Name  | Language | Tags                      |
| --------------- | ----------- | -------- | ------------------------- |
| Bobo Bay Plugin | bobo-plugin | [C#]     | Bobo Bay/BepInEx 5/Plugin |

You're all set! You can either create a project via [CLI](#creating-a-project-cli) or [IDE](#creating-a-project-ide).

### Creating a project (CLI)

If you feel more comfortable with the CLI, you can create a project with the `dotnet new` command.  
The only custom template option is `PluginID`, which you can provide as `--PluginID` or `-P`.

```
dotnet new bobo-plugin --name ExamplePlugin --PluginID com.example.plugin.exampleplugin
```

Once your project is created, you're good to go!  
The template takes care of all references for you, so you can focus on what really matters, rather than mess with project configuration.

When ready to publish, don't forget to [add a license](https://choosealicense.com/)! This is very important in the open source community.  
Additionally, a `.gitignore` file has been included for you to use. Simply move it to the root directory of your project.

### Creating a project (IDE)

Launch your .NET IDE of choice and open the list of available templates.  
If using Rider, this is done by clicking on "New Solution" near the top middle, or top left if on an EAP build, at the time of writing.  
If using Visual Studio Community 2026, this is done by clicking on "Create a new project" on the right.

If the template isn't immediately visible, use the search bar to filter the results.  
Rider will have the templates listed in the "Custom Template" section, beneath the default templates.  
Visual Studio Community 2026 should automatically display the templates at the top of the list after you install them, and will then list them on the left, under "Recent project templates".

Select the template and start filling in the details. When the template asks for a Plugin ID, give it a unique ID no one else will use.

> **It absolutely must be unique** as BepInEx uses it to detect duplicate plugins and sort dependencies. It is recommended (but not mandatory) to use the [reverse domain name notation](https://docs.oracle.com/javase/tutorial/java/package/namingpkgs.html) for GUIDs.

*Source: [BepInEx Documentation: Creating a new plugin project](https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/2_plugin_start.html#basic-information-about-the-plugin)*

Create the project and you're done!  
The template takes care of all references for you, so you can focus on what really matters, rather than mess with project configuration.

When ready to publish, don't forget to [add a license](https://choosealicense.com/)! This is very important in the open source community.  
Additionally, a `.gitignore` file has been included for you to use. Simply move it to the root directory of your project.

## Community

If you ever get stuck or need assistance getting started, feel free to join the official [Bobo Bay Discord Server](https://discord.gg/HjBn4B6X47).  
There's a modding channel where you can share and discuss everything related to mods.

## Credits

- [Jötunn](https://github.com/Valheim-Modding/Jotunn) is licensed under the MIT License. See [LICENSE](https://github.com/Valheim-Modding/Jotunn/blob/dev/LICENSE) for the full License.
  - Automatic game detection for Windows
- [ZumbiBlocksPluginTemplates](https://github.com/wowizowiii/ZumbiBlocksPluginTemplates) is licensed under the MIT License. See [LICENSE](https://github.com/wowizowiii/ZumbiBlocksPluginTemplates/blob/main/LICENSE) for the full License.
  - My other plugin template, adapted for Bobo Bay
