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
        }
    }
}

[HarmonyPatch(typeof(MaliciousFace), "HandleCollision")]
public class FloorPatch : MonoBehaviour
{
    static void Postfix(MaliciousFace __instance,Collision other)
    {
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