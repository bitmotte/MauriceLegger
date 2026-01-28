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

    void Awake()
    {
        animator = GetComponent<Animator>();
        legSpeed = AccessibleConfigs.legSpeed;
        SlowUpdate();
    }

    void Update()
    {
        animator.speed = Vector3.Distance(prevPos, follow.transform.position) * legSpeed;
        if(setRot == true)
        {
            transform.eulerAngles = new(0,follow.transform.GetChild(0).eulerAngles.y,0);   
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
