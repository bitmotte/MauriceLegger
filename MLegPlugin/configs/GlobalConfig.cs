using System.Collections.Generic;

namespace MauriceLegger;

public static class GlobalConfig
{
    public static bool bestiaryIconAlreadyEdited = false;

    public static void InitGlobalConfig()
    {
        InitIndividualVariantChances();
    }

    //legs
    public static bool disableSpiderLegs = true;
    public static bool becomeRagdollOnLanding = true;
    public static bool footsteps = true;

    //tweaks
    public static float timeBetweenSteps = 0.9f;
    public static float footLerpSpeed = 0.1f;
    public static bool footstepsSound = true;
    public static bool footstepsParticle = true;
    public static bool damagedVisual = true;
    public static bool enragedVisual = true;

    //variations
    public static bool variantJingle = true;
    public static float variantChance = 1f;

    public static Dictionary<string,float> individualVariantChances = [];
    public static float totalVariantChances;

    static void InitIndividualVariantChances()
    {
        individualVariantChances.Add("plushie",1);
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

        totalVariantChances = 14;
    }
}