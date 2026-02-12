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
    Transform[] bobbing;
    Vector3 plus = new(0,0.01f,0);

    void Awake()
    {
        animator = GetComponent<Animator>();
        legSpeed = AccessibleConfigs.legSpeed;
        SlowUpdate();

        Transform boneParent = transform.parent.GetChild(0);
        Transform[] bobbingTransforms = [
            boneParent.GetChild(0),
            boneParent.GetChild(1),
            boneParent.GetChild(2),
            boneParent.GetChild(3),
            boneParent.GetChild(4),
            boneParent.GetChild(5),
            boneParent.GetChild(7)
        ];
        bobbing = bobbingTransforms;
    }

    void Update()
    {
        animator.speed = Vector3.Distance(prevPos, follow.transform.position) * legSpeed;
        if(setRot == true)
        {
            transform.eulerAngles = new(0,follow.transform.GetChild(0).eulerAngles.y,0);   
        }

        foreach (Transform bone in bobbing)
        {
            //bone.position += plus;
        }

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
    }
}
