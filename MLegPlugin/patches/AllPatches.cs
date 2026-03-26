using System.Threading;
using HarmonyLib;
using ULTRAKILL.Enemy;
using UnityEngine;

namespace MauriceLegger;

[HarmonyPatch(typeof(MaliciousFace), "Awake")]
public class BallPatch : MonoBehaviour
{
    static void Prefix(MaliciousFace __instance)
    {
        SecretVariations.MakeLegsWithSecretPossibility(__instance.gameObject);
    }
}