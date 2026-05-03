using System.Collections.Generic;
using UnityEngine;

namespace MauriceLegger;
public static class SecretVariations
{
    public static void MakeLegsWithSecretPossibility(GameObject gameObject)
    {
        float luck = Random.Range(0f,maxInclusive:100f);
        if(luck <= GlobalConfig.variantChance)
        {
            float luckTarget = Random.Range(0,GlobalConfig.totalVariantChances);
            
            float i = 0;
            foreach (KeyValuePair<string,float> pair in GlobalConfig.individualVariantChances)
            {
                i += pair.Value;
                if(i == 0) {continue;}
                
                if(i <= luckTarget) {continue;}
                switch (pair.Key)
                {
                    case "plushie":
                        GenericLegs("Assets/Legger/Variations/Plush/Plush.prefab",gameObject);
                        Plugin.Logger.LogInfo("Plushie Variant Loaded");
                        break;
                    case "tutu":
                        GenericLegs("Assets/Legger/Variations/Tutu/Tutu.prefab",gameObject);
                        Plugin.Logger.LogInfo("Tutu Variant Loaded");
                        break;
                    case "stilts":
                        GenericLegs("Assets/Legger/Variations/Stilts/Template.prefab",gameObject);
                        Plugin.Logger.LogInfo("Stilts Variant Loaded");
                        break;
                    case "holding_arms":
                        GenericLegs("Assets/Legger/Variations/HoldingArms/HoldingArms.prefab",gameObject);
                        Plugin.Logger.LogInfo("Holding Arms Variant Loaded");
                        break;
                    case "holding_legs":
                        GenericLegs("Assets/Legger/Variations/HoldingLegs/HoldingLegs.prefab",gameObject);
                        Plugin.Logger.LogInfo("Holding Legs Variant Loaded");
                        break;
                    case "2d":
                        GenericLegs("Assets/Legger/Variations/2D/2D.prefab",gameObject);
                        Plugin.Logger.LogInfo("2D Variant Loaded");
                        break;
                    case "mettaton":
                        GenericLegs("Assets/Legger/Variations/Mettaton/Mettaton.prefab",gameObject);
                        Plugin.Logger.LogInfo("Mettaton Variant Loaded");
                        break;
                    case "sentry":
                        GenericLegs("Assets/Legger/Variations/Sentry/Sentry.prefab",gameObject);
                        Plugin.Logger.LogInfo("Sentry Variant Loaded");
                        break;
                    case "swordsmachine":
                        GenericLegs("Assets/Legger/Variations/Swordsmachine/Swordsmachine.prefab",gameObject);
                        Plugin.Logger.LogInfo("Swordsmachine Variant Loaded");
                        break;
                    case "v2":
                        GenericLegs("Assets/Legger/Variations/ReconstructWhat/ReconstructWhat.prefab",gameObject);
                        Plugin.Logger.LogInfo("Reconstruct What Variant Loaded");
                        break;
                    case "gross":
                        GenericLegs("Assets/Legger/Variations/GrossMaurice/Gross.prefab",gameObject);
                        Plugin.Logger.LogInfo("Gross Maurice Variant Loaded");
                        break;
                    case "mini_maurice":
                        GenericLegs("Assets/Legger/Variations/MiniMaurice/MiniMaurice.prefab",gameObject);
                        Plugin.Logger.LogInfo("Mini Maurice Variant Loaded");
                        break;
                    case "thigh_highs":
                        GenericLegs("Assets/Legger/Variations/ThighHighs/ThighHighs.prefab",gameObject);
                        Plugin.Logger.LogInfo("Thigh Highs Variant Loaded");
                        break;
                    case "hand_legs":
                        GenericLegs("Assets/Legger/Variations/HandLegs/HandLegs.prefab",gameObject);
                        Plugin.Logger.LogInfo("Hand Legs Variant Loaded");
                        break;
                    default:
                        Plugin.Logger.LogInfo("Failed to pick variation");
                        break;
                }
                break;
            }
            if(i != 0) {return;}
        }
        Plugin.Logger.LogInfo("Loaded Generic Legs");
        GenericLegsNoJingle("Assets/Legger/Legs/Legs.prefab",gameObject);
    }
    
    public static void GenericLegs(string key, GameObject malFace)
    {
        AssetBundle bundle = BundleTool.Load("legs.bundle");
        GameObject legs = Object.Instantiate((GameObject)bundle.LoadAsset(key));

        SetupResource.FixShader(legs);
        
        legs.transform.parent = malFace.transform;
        legs.transform.position = malFace.transform.position;

        LegsController controller = legs.AddComponent<LegsController>();
        controller.malFace = malFace.GetComponent<MaliciousFace>();
        controller.variant = true;

        bundle.Unload(false);
    }

    public static void GenericLegsNoJingle(string key, GameObject malFace)
    {
        AssetBundle bundle = BundleTool.Load("legs.bundle");
        GameObject legs = Object.Instantiate((GameObject)bundle.LoadAsset(key));

        SetupResource.FixShader(legs);
        
        legs.transform.parent = malFace.transform;
        legs.transform.position = malFace.transform.position;

        LegsController controller = legs.AddComponent<LegsController>();
        controller.malFace = malFace.GetComponent<MaliciousFace>();
        controller.variant = false;

        bundle.Unload(false);
    }
}
