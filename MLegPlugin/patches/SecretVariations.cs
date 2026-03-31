using UnityEngine;

namespace MauriceLegger;
public static class SecretVariations
{
    public static void MakeLegsWithSecretPossibility(GameObject gameObject)
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
        GenericLegs("Assets/Legger/Legs/Legs.prefab",gameObject);
    }

    public static void GenericLegs(string key, GameObject malFace)
    {
        AssetBundle bundle = BundleTool.Load("legs.bundle");
        GameObject legs = Object.Instantiate((GameObject)bundle.LoadAsset(key));
        SetupResource.FixShader(legs);
        
        legs.transform.parent = malFace.transform.parent;
        legs.transform.position = malFace.transform.position;

        LegsController controller = legs.AddComponent<LegsController>();
        controller.movingBody = malFace.transform;
        controller.turningBody = malFace.transform.GetChild(0);

        bundle.Unload(false);
    }
}
