using UnityEngine.SceneManagement;
using UnityEngine;

namespace MauriceLegger;

public static class SceneUtility
{
    public static string sceneName;
    
    //public static Transform cgArena;

    public static void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        sceneName = scene.name;

        //if(sceneName != "9240e656c89994d44b21940f65ab57da") {return;}
        //cgArena = GameObject.Find("Everything").transform.GetChild(2);
    }
}