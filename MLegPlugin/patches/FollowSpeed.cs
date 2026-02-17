using UnityEngine;

namespace MauriceLegger;

public class FollowSpeed : MonoBehaviour
{
    public GameObject follow;
    public bool wounded;
    public Specials special;
    public bool setRot = true;
    Animator animator;
    Vector3 prevPos = new(0,0,0);
    float legSpeed;
    Transform childOffsetters;
    Transform baseBone;
    Vector3 offset;

    void Awake()
    {
        animator = GetComponent<Animator>();
        legSpeed = AccessibleConfigs.legSpeed;
        SlowUpdate();

        childOffsetters = transform.parent.GetChild(0);

        baseBone = transform.GetChild(1).GetChild(0);

        SitDetector detector = transform.GetChild(1).GetChild(0).GetChild(2).gameObject.AddComponent<SitDetector>();
        detector.animator = animator;
    }

    void Update()
    {
        animator.speed = Vector3.Distance(prevPos, follow.transform.position) * legSpeed;
        if(setRot == true)
        {
            transform.eulerAngles = new(0,follow.transform.GetChild(0).eulerAngles.y,0);   
        }

        Vector3 prevOffset = offset;
        childOffsetters.position -= prevOffset;
        offset = baseBone.position - childOffsetters.position;

        childOffsetters.position += offset;

        prevPos = follow.transform.position;
    }

    void SlowUpdate()
    {
        Invoke("SlowUpdate", 1f);

        if(setRot == false)
        {
            legSpeed = AccessibleConfigs.legSpeed / 4;
            return;
        }
        legSpeed = AccessibleConfigs.legSpeed;

        if(AccessibleConfigs.legacyRun == true)
        {
            animator.SetBoolString("legacy_run",true);
        }
        else
        {
            animator.SetBoolString("legacy_run",false);
        }
    }
}
