using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace MauriceLegger;

public static class SetupResource
{
    public static GameObject FixShader(GameObject gameObject)
    {
        // Load material with "ULTRAKILL/Master" shader . . . and grab its shader
        Shader Master = Addressables.LoadAssetAsync<Material>("Assets/Materials/Environment/Metal/Pattern 1/Metal Pattern 1 8.mat").WaitForCompletion().shader;
        
        foreach (SkinnedMeshRenderer dynamic in gameObject.GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            foreach (Material mat in dynamic.materials)
            {
                mat.shader = Master;
            }
        }

        foreach (MeshRenderer still in gameObject.GetComponentsInChildren<MeshRenderer>())
        {
            foreach (Material mat in still.materials)
            {
                mat.shader = Master;
            }
        }

        foreach (ParticleSystem particle in gameObject.GetComponentsInChildren<ParticleSystem>())
        {
            foreach (Renderer still in particle.gameObject.GetComponentsInChildren<Renderer>())
            {
                foreach (Material mat in still.materials)
                {
                    mat.shader = Master;
                }
            }
        }

        foreach (EnemySimplifier simplifier in gameObject.GetComponentsInChildren<EnemySimplifier>())
        {
            simplifier.simplifiedMaterial.shader = Master;
            simplifier.enragedSimplifiedMaterial.shader = Master;
            simplifier.enragedMaterial.shader = Master;
            simplifier.enemyColorType = EnemyType.Cerberus;
        }

        return gameObject;
    }
}