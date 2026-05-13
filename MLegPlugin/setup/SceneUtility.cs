using UnityEngine;
using UnityEngine.SceneManagement;

namespace MauriceLegger;

public static class SceneUtility
{
    public static string sceneName;

    public static void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        sceneName = scene.name;

        GameObject loader = new("aaa");
        loader.transform.parent = null;
        loader.AddComponent<SetPhysLegs>();
    }
}