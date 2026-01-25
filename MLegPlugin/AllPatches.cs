using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;

namespace MauriceLegger;

[HarmonyPatch(typeof(SpiderBody), "Awake")]
public class MauriceDeathPatch : MonoBehaviour
{
    static void Prefix(SpiderBody __instance)
    {
        GameObject legs = Instantiate(LoadBundle.legs);
        legs.transform.parent = __instance.transform;
        legs.transform.localPosition = new(0f, -0.96f, 0f);
        legs.transform.localScale = new(0.1f, 0.12f, 0.1f);

        Shader mauriceShader = __instance.transform.GetChild(0).GetChild(5).GetComponent<SkinnedMeshRenderer>().material.shader;

        SkinnedMeshRenderer renderer = legs.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>();
        Material newMat = new(mauriceShader)
        {
            mainTexture = LoadBundle.tex
        };
        newMat.EnableKeyword("ENEMY");
        newMat.EnableKeyword("VERTEX_LIGHTING");
        newMat.EnableKeyword("_FOG_ON");
        newMat.EnableKeyword("_USEALBEDOASEMISSIVE_ON");
        newMat.EnableKeyword("_VERTEXCOLORS_ON");
        newMat.EnableKeyword("_VERTEXLIGHTING_ON");
        newMat.EnableKeyword("_ZWRITE_ON");
        renderer.material = newMat;

        FollowSpeed legFollow = legs.AddComponent<FollowSpeed>();
        legFollow.follow = __instance.gameObject;

        legs.transform.GetChild(0).gameObject.layer = true ? 25 : 24;

        GameObject[] newTargets = [__instance.transform.GetChild(0).GetChild(5).gameObject, legs.transform.GetChild(0).gameObject];

        OutdoorsChecker outdoorsChecker = __instance.GetComponentInChildren<OutdoorsChecker>();
        outdoorsChecker.targets = newTargets;

        EnemySimplifier simplifier = legs.transform.GetChild(0).gameObject.AddComponent<EnemySimplifier>();
    }   
}