using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using PluginConfig.API;
using UnityEngine.SceneManagement;

namespace MauriceLegger;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency("com.eternalUnion.pluginConfigurator")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    public static PluginConfigurator config;
    
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();

        config = MauriceConfigurator.CreateConfigurator();
        SceneManager.sceneLoaded += OnSceneLoad;
    }

    public static void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        LoadBundle.Load();
    }
}
