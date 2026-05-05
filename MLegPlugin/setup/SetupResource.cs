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
                if(mat.shader.name == "ULTRAKILL/Master")
                {
                    mat.shader = Master;
                }
                if(mat.shader.name == "Hidden/InternalErrorShader")
                {
                    mat.shader = Addressables.LoadAssetAsync<Material>("Assets/Materials/Dev/FadeToWhite.mat").WaitForCompletion().shader;
                }
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
            if(simplifier.simplifiedMaterial) {simplifier.simplifiedMaterial.shader = Master;}
            if(simplifier.simplifiedMaterial2) {simplifier.simplifiedMaterial2.shader = Master;}
            
            if(simplifier.enragedMaterial) {
                if(simplifier.enragedMaterial.shader.name == "ULTRAKILL/Master")
                {
                    simplifier.enragedMaterial.shader = Master;
                }
                if(simplifier.enragedMaterial.shader.name == "Hidden/InternalErrorShader")
                {
                    simplifier.enragedMaterial.shader = Addressables.LoadAssetAsync<Material>("Assets/Materials/Dev/FadeToWhite.mat").WaitForCompletion().shader;
                }
            }
           
            if(simplifier.enragedSimplifiedMaterial) {simplifier.enragedSimplifiedMaterial.shader = Master;}
        }
        foreach (Footsteps footstepsController in gameObject.GetComponentsInChildren<Footsteps>())
        {
            if(footstepsController.footstep == null) {continue;};
            foreach (MeshRenderer renderer in footstepsController.footstep.GetComponentsInChildren<MeshRenderer>())
            {
                foreach (Material mat in renderer.materials)
                {
                    mat.shader = Addressables.LoadAssetAsync<Material>("Assets/Materials/Dev/FadeToWhite.mat").WaitForCompletion().shader;
                }
            }
        }

        return gameObject;
    }
}