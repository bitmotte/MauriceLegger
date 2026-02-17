using UnityEngine;

namespace MauriceLegger;

public class SitDetector : MonoBehaviour
{
    bool disable;
    public Animator animator;
    public void OnTriggerEnter(Collider other)
    {
        if(disable == true) {return;}
        if(AccessibleConfigs.sit == true )
        {
            animator.SetBoolString("sitting", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(disable == true) {return;}
        animator.SetBoolString("sitting", false);
    }

    public void Disable()
    {
        disable = true;
        animator.SetBoolString("sitting", false);
    }
}