using UnityEngine;

namespace MauriceLegger;

public class FollowSpeed : MonoBehaviour
{
    public GameObject follow;
    Animator animator;
    Vector3 prevPos = new(0,0,0);
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.speed = Vector3.Distance(prevPos, follow.transform.position) * 120;
        transform.eulerAngles = new(0,follow.transform.GetChild(0).eulerAngles.y,0);
        prevPos = follow.transform.position;
    }
}
