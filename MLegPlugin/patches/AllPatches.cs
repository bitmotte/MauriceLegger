using System.Threading;
using HarmonyLib;
using ULTRAKILL.Enemy;
using UnityEngine;

namespace MauriceLegger;

[HarmonyPatch(typeof(MaliciousFace), "Start")]
public class LegPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        if(GlobalConfig.disableSpiderLegs)
        {
            foreach (LineRenderer spiderLeg in __instance.transform.parent.GetComponentsInChildren<LineRenderer>())
            {
                spiderLeg.startColor = new(0,0,0,0);
                spiderLeg.endColor = new(0,0,0,0);
            }
        }
        SecretVariations.MakeLegsWithSecretPossibility(__instance.gameObject);
    }
}

[HarmonyPatch(typeof(MaliciousFace), "HandleSpiderDamage")]
public class WoundPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance, ref DamageData data)
    {
        if(!GlobalConfig.damagedVisual) {return;}
        if(!__instance.eid.dead)
        {
            if (__instance.spider.health >= __instance.maxHealth / 2f && __instance.spider.health - data.damage < __instance.maxHealth / 2f)
            {
                LegsController[] controllers = __instance.transform.parent.GetComponentsInChildren<LegsController>();
                foreach (LegsController controller in controllers)
                {
                    controller.SwitchToDamagedVisuals();
                }
            }
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "ProcessDeath")]
public class DeathPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        LegsController[] controllers = __instance.transform.parent.GetComponentsInChildren<LegsController>();
        foreach (LegsController controller in controllers)
        {
            controller.UnEnrage();
            controller.SwitchToHealthyVisuals();
            controller.Death();
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "HandleCollision")]
public class FloorPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance,Collision other)
    {
        if(!GlobalConfig.becomeRagdollOnLanding) {return;}
        
        LegsController[] controllers = __instance.transform.parent.GetComponentsInChildren<LegsController>();
        if(other.gameObject.CompareTag("Floor"))
        {
            foreach (LegsController controller in controllers)
            {
                controller.SwitchToPhysical();
            }
        }   
        
    }
}

[HarmonyPatch(typeof(MaliciousFace), "Enrage")]
public class EnragePatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        if(!GlobalConfig.enragedVisual) {return;}

        LegsController[] controllers = __instance.transform.parent.GetComponentsInChildren<LegsController>();
        foreach (LegsController controller in controllers)
        {
            controller.Enrage();
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "UnEnrage")]
public class UnEnragePatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        LegsController[] controllers = __instance.transform.parent.GetComponentsInChildren<LegsController>();
        foreach (LegsController controller in controllers)
        {
            controller.UnEnrage();
        }
    }
}

[HarmonyPatch(typeof(EnemyInfoPage), "Start")]
public class BestiaryIcon : MonoBehaviour
{
    static void Prefix(EnemyInfoPage __instance)
    {
        if(GlobalConfig.bestiaryIconAlreadyEdited) {return;}

        AssetBundle bundle = BundleTool.Load("legs.bundle");

        SpawnableObject[] newBestiary = [];
        foreach (SpawnableObject obj in __instance.objects.enemies)
        {
            if(obj.objectName == "Malicious Face")
            {
                SpawnableObject spawnable = (SpawnableObject)bundle.LoadAsset("Assets/Legger/Bestiary/Obj.asset");
                SetupResource.FixShader(spawnable.preview);

                obj.gridIcon = spawnable.gridIcon;
                obj.preview = spawnable.preview;
            }
            newBestiary = [.. newBestiary, obj];
        }
        __instance.objects.enemies = newBestiary;

        GlobalConfig.bestiaryIconAlreadyEdited = true;

        bundle.Unload(false);
    }
}

[HarmonyPatch(typeof(SpawnMenu), "Awake")]
public class SandboxIcon : MonoBehaviour
{
    static void Prefix(SpawnMenu __instance)
    {
        if(GlobalConfig.bestiaryIconAlreadyEdited) {return;}

        AssetBundle bundle = BundleTool.Load("legs.bundle");

        SpawnableObject[] newBestiary = [];
        foreach (SpawnableObject obj in __instance.objects.enemies)
        {
            if(obj.objectName == "Malicious Face")
            {
                SpawnableObject spawnable = (SpawnableObject)bundle.LoadAsset("Assets/Legger/Bestiary/Obj.asset");
                SetupResource.FixShader(spawnable.preview);

                obj.gridIcon = spawnable.gridIcon;
                obj.preview = spawnable.preview;
            }
            newBestiary = [.. newBestiary, obj];
        }
        __instance.objects.enemies = newBestiary;

        GlobalConfig.bestiaryIconAlreadyEdited = true;

        bundle.Unload(false);
    }
}