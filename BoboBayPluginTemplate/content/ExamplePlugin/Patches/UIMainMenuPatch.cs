using BobosWorld;
using HarmonyLib;
using UnityEngine;

namespace ExamplePlugin.Patches;

[HarmonyPatch(typeof(UIMainMenu))]
public static class UIMainMenuPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(UIMainMenu.Awake))]
    public static void ExamplePatch()
    {
        Plugin.Logger.LogInfo($"Current game version is {Application.version}");
    }
}
