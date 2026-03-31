using System.Threading;
using HarmonyLib;
using ULTRAKILL.Enemy;
using UnityEngine;

namespace MauriceLegger;

[HarmonyPatch(typeof(MaliciousFace), "Start")]
public class LegPatch : MonoBehaviour
{
    static void Prefix(MaliciousFace __instance)
    {
        foreach (LineRenderer spiderLeg in __instance.transform.parent.GetComponentsInChildren<LineRenderer>())
        {
            spiderLeg.startColor = new(0,0,0,0);
            spiderLeg.endColor = new(0,0,0,0);
        }
        SecretVariations.MakeLegsWithSecretPossibility(__instance.gameObject);
    }
}

[HarmonyPatch(typeof(MaliciousFace), "HandleSpiderDamage")]
public class WoundPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance, ref DamageData data)
    {
        if(!__instance.eid.dead)
        {
            if (__instance.spider.health >= __instance.maxHealth / 2f && __instance.spider.health - data.damage < __instance.maxHealth / 2f)
            {
                LegsController controller = __instance.transform.parent.GetComponentInChildren<LegsController>();
                controller.SwitchToDamagedVisuals();
            }
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "ProcessDeath")]
public class DeathPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        LegsController controller = __instance.transform.parent.GetComponentInChildren<LegsController>();
        controller.UnEnrage();
        controller.SwitchToHealthyVisuals();
    }
}

[HarmonyPatch(typeof(MaliciousFace), "HandleCollision")]
public class FloorPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance,Collision other)
    {
        LegsController controller = __instance.transform.parent.GetComponentInChildren<LegsController>();
        if(other.gameObject.CompareTag("Floor"))
        {
            controller.SwitchToPhysicalLegs();
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "Enrage")]
public class EnragePatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        LegsController controller = __instance.transform.parent.GetComponentInChildren<LegsController>();
        controller.Enrage();
    }
}

[HarmonyPatch(typeof(MaliciousFace), "UnEnrage")]
public class UnEnragePatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance)
    {
        LegsController controller = __instance.transform.parent.GetComponentInChildren<LegsController>();
        controller.UnEnrage();
    }
}