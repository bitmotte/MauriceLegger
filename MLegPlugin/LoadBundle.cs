using UnityEngine;
using UnityEngine.SceneManagement;

namespace MauriceLegger;

public static class LoadBundle
{
    public static GameObject legs;
    public static Texture2D texHealthy;
    public static Texture2D texEnraged;

    public static void Load()
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(Pathing.GetPluginPath() + "/leg.bundle");
        legs = (GameObject)bundle.LoadAsset("Assets/legs.prefab");
        texHealthy = (Texture2D)bundle.LoadAsset("Assets/T_Cerberus.png");
        texEnraged = (Texture2D)bundle.LoadAsset("Assets/T_CerberusEnraged.png");
        bundle.Unload(false);
    }
}