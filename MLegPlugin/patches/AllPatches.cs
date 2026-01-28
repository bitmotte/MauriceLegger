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
        LineRenderer[] legRenderers = __instance.transform.parent.GetComponentsInChildren<LineRenderer>();
        Color none = new(0,0,0,0);
        foreach (LineRenderer legRenderer in legRenderers)
        {
            legRenderer.startColor = none;
            legRenderer.endColor = none;
        }


        System.Random rnd = new System.Random();
        int chosen = rnd.Next(100);

        GameObject legsToInstantiate = new();
        Specials specialToGive = Specials.normal;
        Texture2D texToGive = LoadBundle.texHealthy;
        Texture2D texToGiveEnraged = LoadBundle.texEnraged;
        switch (chosen)
        {
            case 0:
                if(!AccessibleConfigs.armLegs)
                {
                    legsToInstantiate = LoadBundle.legs;
                    specialToGive = Specials.normal;
                    texToGive = LoadBundle.texHealthy;
                    texToGiveEnraged = LoadBundle.texEnraged;
                    break;
                }
                legsToInstantiate = LoadBundle.arms;
                specialToGive = Specials.arms;
                texToGive = LoadBundle.texHealthy;
                texToGiveEnraged = LoadBundle.texEnraged;
                break;
            case 1:
                if(!AccessibleConfigs.mauriceLegs)
                {
                    legsToInstantiate = LoadBundle.legs;
                    specialToGive = Specials.normal;
                    texToGive = LoadBundle.texHealthy;
                    texToGiveEnraged = LoadBundle.texEnraged;
                    break;
                }
                legsToInstantiate = LoadBundle.maurice;
                specialToGive = Specials.maurice;
                texToGive = LoadBundle.texMaurice;
                texToGiveEnraged = LoadBundle.texEnragedMaurice;
                break;
            case 2:
                if(!AccessibleConfigs.thighs)
                {
                    legsToInstantiate = LoadBundle.legs;
                    specialToGive = Specials.normal;
                    texToGive = LoadBundle.texHealthy;
                    texToGiveEnraged = LoadBundle.texEnraged;
                    break;
                }
                legsToInstantiate = LoadBundle.legs;
                specialToGive = Specials.thighs;
                texToGive = LoadBundle.texThighs;
                texToGiveEnraged = LoadBundle.texThighsEnraged;
                break;
            default:
                legsToInstantiate = LoadBundle.legs;
                specialToGive = Specials.normal;
                texToGive = LoadBundle.texHealthy;
                texToGiveEnraged = LoadBundle.texEnraged;
                break;
        }
        
        
        GameObject legs = Instantiate(legsToInstantiate);
        legs.transform.parent = __instance.transform;
        legs.transform.localPosition = new(0f, -0.96f, 0f);
        legs.transform.localScale = new(0.1f, 0.12f, 0.1f);

        Shader mauriceShader = __instance.transform.GetChild(0).GetChild(5).GetComponent<SkinnedMeshRenderer>().material.shader;

        SkinnedMeshRenderer renderer = legs.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>();
        Material newMat = new(mauriceShader)
        {
            mainTexture = texToGive
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
            mainTexture = texToGiveEnraged
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
        legFollow.special = specialToGive;

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
            EnemySimplifier simplifier = __instance.transform.GetChild(3).GetChild(0).GetComponent<EnemySimplifier>();
            simplifier.ChangeMaterialNew(EnemySimplifier.MaterialState.enraged, simplifier.enragedMaterial);
        }
    }

    [HarmonyPatch(typeof(SpiderBody), "UnEnrage")]
    public class MauriceUnEnragePatch : MonoBehaviour
    {
        static void Postfix(SpiderBody __instance)
        {
            EnemySimplifier simplifier = __instance.transform.GetChild(3).GetChild(0).GetComponent<EnemySimplifier>();
            simplifier.ChangeMaterialNew(EnemySimplifier.MaterialState.normal, simplifier.originalMaterial);
        }
    }

    [HarmonyPatch(typeof(SpiderBody), "GetHurt")]
    public class MauriceWoundPatch : MonoBehaviour
    {
        static void Postfix(SpiderBody __instance)
        {
            EnemyIdentifier eid = __instance.GetComponent<EnemyIdentifier>();
            if(eid.dead) {return;}

            Traverse instanceFields = Traverse.Create(__instance);
            float health = (float)instanceFields.Field("health").GetValue();
            float maxHealth = (float)instanceFields.Field("maxHealth").GetValue();

            GameObject legs = __instance.transform.GetChild(3).gameObject;
            FollowSpeed followSpeed = legs.GetComponent<FollowSpeed>();
            bool wounded = followSpeed.wounded;

            if(health < maxHealth / 2f && !wounded)
            {
                Shader mauriceShader = __instance.transform.GetChild(0).GetChild(5).GetComponent<SkinnedMeshRenderer>().material.shader;

                SkinnedMeshRenderer renderer = legs.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>();
                Mesh newMesh = LoadBundle.legsDamaged.transform.GetChild(0).GetComponent<SkinnedMeshRenderer>().sharedMesh;
                if(followSpeed.special != Specials.normal)
                {
                    EnemySimplifier simplifier1 = legs.transform.GetChild(0).gameObject.GetComponent<EnemySimplifier>();
                    renderer.material = simplifier1.originalMaterial;
                    return;
                }
                renderer.sharedMesh = newMesh;

                Material newMat = new(mauriceShader)
                {
                    mainTexture = LoadBundle.texDamaged
                };
                newMat.EnableKeyword("ENEMY");
                newMat.EnableKeyword("VERTEX_LIGHTING");
                newMat.EnableKeyword("_FOG_ON");
                newMat.EnableKeyword("_USEALBEDOASEMISSIVE_ON");
                newMat.EnableKeyword("_VERTEXCOLORS_ON");
                newMat.EnableKeyword("_VERTEXLIGHTING_ON");
                newMat.EnableKeyword("_ZWRITE_ON");
                renderer.material = newMat;

                EnemySimplifier simplifier = legs.transform.GetChild(0).gameObject.GetComponent<EnemySimplifier>();
                simplifier.originalMaterial = newMat;
                simplifier.simplifiedMaterial = newMat;
                //simplifier.

                Material newEnragedMat = new(mauriceShader)
                {
                    mainTexture = LoadBundle.texEnragedDamaged
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

                FollowSpeed legFollow = legs.GetComponent<FollowSpeed>();
                legFollow.wounded = true;

                legs.transform.GetChild(0).gameObject.layer = true ? 25 : 24;
            }
        }
    }

    [HarmonyPatch(typeof(SpiderBody), "Die")]
    public class MauriceBallerDeathPatch : MonoBehaviour
    {
        static void Prefix(SpiderBody __instance)
        {
            FollowSpeed followSpeed = __instance.transform.GetChild(3).GetComponent<FollowSpeed>();
            followSpeed.setRot = false;
        }
    }
}