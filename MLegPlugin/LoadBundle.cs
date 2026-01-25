using UnityEngine;
using UnityEngine.SceneManagement;

namespace MauriceLegger;

public static class LoadBundle
{
    public static GameObject legs;
    public static Texture2D tex;

    public static void Load()
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(Pathing.GetPluginPath() + "/leg.bundle");
        legs = (GameObject)bundle.LoadAsset("Assets/legs.prefab");
        tex = (Texture2D)bundle.LoadAsset("Assets/T_Cerberus.png");
        bundle.Unload(false);
    }
}