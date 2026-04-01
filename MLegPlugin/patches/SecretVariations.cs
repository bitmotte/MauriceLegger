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
                    GenericLegs("Assets/Legger/Variations/Tutu/Tutu.prefab",gameObject);
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
        GameObject step = (GameObject)bundle.LoadAsset("Assets/Legger/Legs/Footstep.prefab");
        legs.GetComponentInChildren<Footsteps>().footstep = step;

        SetupResource.FixShader(legs);
        
        legs.transform.parent = malFace.transform.parent;
        legs.transform.position = malFace.transform.position;

        LegsController controller = legs.AddComponent<LegsController>();
        controller.movingBody = malFace.transform;
        controller.turningBody = malFace.transform.GetChild(0);
        controller.malFace = malFace.GetComponent<MaliciousFace>();

        bundle.Unload(false);
    }
}
