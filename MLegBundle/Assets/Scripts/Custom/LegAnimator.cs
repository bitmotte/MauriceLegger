using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegAnimator : MonoBehaviour
{
    public Transform movingBody;
    public Transform turningBody;
    Transform armature;
    public Vector3 armatureOffset;
    Vector3 angleOffset;

    //leg animation things
    public float lerpSpeed = 0.2f;
    public float stepTime = .5f;

    public Rigidbody malFaceBody;

    public Transform leftTarget;
    Vector3 leftTargetTarget;
    bool canTargetLeft;

    public Transform rightTarget;
    Vector3 rightTargetTarget;
    bool canTargetRight;


    public Transform leftRayPoint;
    public Transform rightRayPoint;

    LayerMask mask;

    void Awake()
    {
        armature = gameObject.transform.GetChild(0).GetChild(1);
        //armatureOffset = new(-0.1f, 0.5f, 0);
        angleOffset = new(0,0,0);

        leftRayPoint = armature.GetChild(0).GetChild(2);
        rightRayPoint = armature.GetChild(0).GetChild(3);

        leftTarget = transform.GetChild(1).GetChild(0).GetChild(0);
        rightTarget = transform.GetChild(1).GetChild(1).GetChild(0);
    }

    void Start()
    {
        StepLeft();
    }

    void FixedUpdate()
    {
        armature.position = movingBody.position + armatureOffset;
        armature.eulerAngles = new(armature.eulerAngles.x,turningBody.eulerAngles.y,armature.eulerAngles.z);
        if(canTargetLeft == true) {leftTarget.position = Vector3.Lerp(leftTarget.position,leftTargetTarget,lerpSpeed);}
        if(canTargetRight == true) {rightTarget.position = Vector3.Lerp(rightTarget.position,rightTargetTarget,lerpSpeed);}
    }

    void StepLeft()
    {
        Invoke("StepRight",stepTime);
        if (Physics.Raycast(leftRayPoint.position, leftRayPoint.up, out RaycastHit hit))
        {
            canTargetLeft = true;
            leftTargetTarget = hit.point + Vector3.up;
        }
        else if(canTargetLeft == true)
        {
            canTargetLeft = false;
        }
    }

    void StepRight()
    {
        Invoke("StepLeft",stepTime);
        if(Physics.Raycast(rightRayPoint.position, rightRayPoint.up, out RaycastHit hit))
        {
            canTargetRight = true;
            rightTargetTarget = hit.point + Vector3.up;
        } 
        else if(canTargetRight == true)
        {
            canTargetRight = false;
        }
    }
}
