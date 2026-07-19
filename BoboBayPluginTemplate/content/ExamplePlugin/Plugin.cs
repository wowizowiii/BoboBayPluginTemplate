using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace ExamplePlugin;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal new static ManualLogSource Logger;
    
    private void Awake()
    {
        Logger = base.Logger;
        Harmony.CreateAndPatchAll(typeof(Plugin).Assembly, Info.Metadata.GUID);
    }
}
