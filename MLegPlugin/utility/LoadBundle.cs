using UnityEngine;
using UnityEngine.SceneManagement;

namespace MauriceLegger;

public static class LoadBundle
{
    public static GameObject legs;
    public static Texture2D texHealthy;
    public static Texture2D texEnraged;
    public static GameObject legsDamaged;
    public static Texture2D texDamaged;
    public static Texture2D texEnragedDamaged;
    public static GameObject arms;

    public static GameObject maurice;
    public static Texture2D texMaurice;
    public static Texture2D texEnragedMaurice;

    public static Texture2D texThighs;
    public static Texture2D texThighsEnraged;

    public static void Load()
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(Pathing.GetPluginPath() + "/leg.bundle");
        legs = (GameObject)bundle.LoadAsset("Assets/legs.prefab");
        texHealthy = (Texture2D)bundle.LoadAsset("Assets/T_Cerberus.png");
        texEnraged = (Texture2D)bundle.LoadAsset("Assets/T_CerberusEnraged.png");
        
        legsDamaged = (GameObject)bundle.LoadAsset("Assets/legs_cracked.prefab");
        texDamaged = (Texture2D)bundle.LoadAsset("Assets/T_Cerberus_Damaged.png");
        texEnragedDamaged = (Texture2D)bundle.LoadAsset("Assets/T_CerberusEnragedDamaged.png");

        maurice = (GameObject)bundle.LoadAsset("Assets/maurice.prefab");
        texMaurice = (Texture2D)bundle.LoadAsset("Assets/T_MaliciousFace.png");
        texEnragedMaurice = (Texture2D)bundle.LoadAsset("Assets/T_MaliciousFaceEnraged.png");

        texThighs = (Texture2D)bundle.LoadAsset("Assets/T_CerberusThighs.png");
        texThighsEnraged = (Texture2D)bundle.LoadAsset("Assets/T_CerberusThighsEnraged.png");

        arms = (GameObject)bundle.LoadAsset("Assets/arms.prefab");
        bundle.Unload(false);
    }
}