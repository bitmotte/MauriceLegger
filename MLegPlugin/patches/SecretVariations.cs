using UnityEngine;

namespace MauriceLegger;
public static class SecretVariations
{
    public static void MakeBallWithSecretPossibility(GameObject gameObject)
    {
        //1,101 for 1 in 100 chance
        int luck = Random.RandomRangeInt(1,101);
        if(luck == 1)
        {
            int luckVariation = Random.RandomRangeInt(1,2);
            switch (luckVariation)
            {
                default:
                    
                    break;
            }
            return;
        }
        GenericLegs("???",gameObject);
    }

    public static void GenericLegs(string key, GameObject malFace)
    {
        AssetBundle bundle = BundleTool.Load("balls.bundle");
        GameObject legs = (GameObject)bundle.LoadAsset(key);
        SetupResource.FixShader(legs);
        
        legs.transform.parent = malFace.transform;

        Object.Instantiate(legs);

        bundle.Unload(false);
    }
}
