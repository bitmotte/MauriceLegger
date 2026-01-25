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
            mainTexture = LoadBundle.texHealthy
        };
        newMat.EnableKeyword("ENEMY");
        newMat.EnableKeyword("VERTEX_LIGHTING");
        newMat.EnableKeyword("_FOG_ON");
        newMat.EnableKeyword("_USEALBEDOASEMISSIVE_ON");
        newMat.EnableKeyword("_VERTEXCOLORS_ON");
        newMat.EnableKeyword("_VERTEXLIGHTING_ON");
        newMat.EnableKeyword("_ZWRITE_ON");
        renderer.material = newMat;

        EnemySimplifier simplifier = legs.transform.GetChild(0).gameObject.AddComponent<EnemySimplifier>();
        simplifier.originalMaterial = newMat;
        simplifier.simplifiedMaterial = newMat;

        Material newEnragedMat = new(mauriceShader)
        {
            mainTexture = LoadBundle.texEnraged
        };
        newEnragedMat.EnableKeyword("ENEMY");
        newEnragedMat.EnableKeyword("VERTEX_LIGHTING");
        newEnragedMat.EnableKeyword("_FOG_ON");
        newEnragedMat.EnableKeyword("_USEALBEDOASEMISSIVE_ON");
        newEnragedMat.EnableKeyword("_VERTEXCOLORS_ON");
        newEnragedMat.EnableKeyword("_VERTEXLIGHTING_ON");
        newEnragedMat.EnableKeyword("_ZWRITE_ON");

        simplifier.enragedMaterial = newEnragedMat;
        simplifier.enragedSimplifiedMaterial = newEnragedMat;

        FollowSpeed legFollow = legs.AddComponent<FollowSpeed>();
        legFollow.follow = __instance.gameObject;

        legs.transform.GetChild(0).gameObject.layer = true ? 25 : 24;

        GameObject[] newTargets = [__instance.transform.GetChild(0).GetChild(5).gameObject, legs.transform.GetChild(0).gameObject];

        OutdoorsChecker outdoorsChecker = __instance.GetComponentInChildren<OutdoorsChecker>();
        outdoorsChecker.targets = newTargets;
    }

    [HarmonyPatch(typeof(SpiderBody), "Enrage")]
    public class MauriceEnragePatch : MonoBehaviour
    {
        static void Postfix(SpiderBody __instance)
        {
            EnemySimplifier simplifier = __instance.transform.GetChild(3).GetChild(0).GetComponent<EnemySimplifier>();;
            simplifier.ChangeMaterialNew(EnemySimplifier.MaterialState.enraged, simplifier.enragedMaterial);
        }
    }
}