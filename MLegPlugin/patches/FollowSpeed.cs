using UnityEngine;

namespace MauriceLegger;

public class FollowSpeed : MonoBehaviour
{
    public GameObject follow;
    public bool wounded;
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
        transform.eulerAngles = new(0,follow.transform.GetChild(0).eulerAngles.y,0);
        prevPos = follow.transform.position;
    }

    void SlowUpdate()
    {
        Invoke("SlowUpdate", 1f);

        legSpeed = AccessibleConfigs.legSpeed;
    }
}
