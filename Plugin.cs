using BepInEx;
using BepInEx.Unity.IL2CPP;
using SpiderAPI.Events;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using SpiderAPI.Spider;
using HarmonyLib;

namespace SpiderAPI;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin {
    private static Harmony harmony;
    public override void Load() {
        // Plugin startup logic
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)EventsAPI.OnSceneChanged;
        EventsAPI.onLoadLevel += PlayerAPI.InitAPI;
        harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
    }
}
