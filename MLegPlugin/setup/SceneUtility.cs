using UnityEngine.SceneManagement;
using UnityEngine;

namespace MauriceLegger;

public static class SceneUtility
{
    public static string sceneName;

    public static void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        sceneName = scene.name;
    }
}