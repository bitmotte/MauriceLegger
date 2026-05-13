using System;
using UnityEngine;

namespace MauriceLegger;

class SetPhysLegs : MonoBehaviour
{
    void Start()
    {
        Invoke("Wagh", 0.1f);
    }

    void Wagh()
    {
        AssetBundle bundle = BundleTool.Load("legs.bundle");
        GameObject legs = (GameObject)bundle.LoadAsset("Assets/Legger/Legs/Physical/Baller.prefab");
        SetupResource.FixShader(legs);

        MauriceBridge.Store.storedPhysicalLeg = legs;

        bundle.Unload(false);
    }
}