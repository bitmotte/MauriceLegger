using UnityEngine;

namespace MauriceLegger;

public class FootstepConfigCheck : MonoBehaviour
{
    Animator controller;

    void Start()
    {
        controller = GetComponent<Animator>();

        if(GlobalConfig.footstepsSound) {controller.SetBoolString("Audio",true);}
        if(GlobalConfig.footstepsParticle) {controller.SetBoolString("Particle",true);}
    }
}