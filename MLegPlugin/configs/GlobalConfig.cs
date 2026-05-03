using System.Collections.Generic;
using UnityEngine;

namespace MauriceLegger;

public static class GlobalConfig
{
    public static void InitGlobalConfig()
    {
        InitIndividualVariantChances();
    }

    //legs
    public static bool disableSpiderLegs;
    public static bool becomeRagdollOnLanding;
    public static bool footsteps;

    //tweaks
    public static float timeBetweenSteps;
    public static bool footstepsSound;
    public static bool footstepsParticle;
    public static bool damagedVisual;
    public static bool enragedVisual;

    //variations
    public static bool variantJingle = true;
    public static float variantChance = 1f;

    public static Dictionary<string,float> individualVariantChances = [];
    public static float totalVariantChances;

    static void InitIndividualVariantChances()
    {
        individualVariantChances.Add("plushie",1f);
        individualVariantChances.Add("tutu",1);
        individualVariantChances.Add("stilts",1);
        individualVariantChances.Add("holding_arms",1);
        individualVariantChances.Add("holding_legs",1);
        individualVariantChances.Add("2d",1);
        individualVariantChances.Add("mettaton",1);
        individualVariantChances.Add("sentry",1);
        individualVariantChances.Add("swordsmachine",1);
        individualVariantChances.Add("v2",1);
        individualVariantChances.Add("gross",1);
        individualVariantChances.Add("mini_maurice",1);
        individualVariantChances.Add("thigh_highs",1);
        individualVariantChances.Add("hand_legs",1);
    }
}