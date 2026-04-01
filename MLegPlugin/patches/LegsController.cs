using UnityEngine;

namespace MauriceLegger;
public class LegsController : MonoBehaviour
{
    public Transform movingBody;
    public Transform turningBody;
    Transform armature;
    public Vector3 armatureOffset;
    Vector3 angleOffset;
    public MaliciousFace malFace;

    //leg animation things
    public float lerpSpeed = 0.2f;
    public float stepTime = .5f;

    public Rigidbody malFaceBody;

    public Transform leftTarget;
    Vector3 leftTargetTarget;

    public Transform rightTarget;
    Vector3 rightTargetTarget;


    public Transform leftRayPoint;
    public Transform rightRayPoint;

    public LayerMask mask;

    bool isPhysical;
    Transform nonPhysicalLegs;
    Transform physicalLegs;

    Transform physicalArmature;

    //renderers
    public bool alreadyChangedModel;
    SkinnedMeshRenderer HealthyLeft;
    SkinnedMeshRenderer HealthyRight;

    SkinnedMeshRenderer DamagedLeft;
    SkinnedMeshRenderer DamagedRight;

    EnemySimplifier[] ensims = [];

    //footsteps
    Transform footstepDestination;
    Footsteps footstepsController;
    Vector3 toTargetTarget;

    void Awake()
    {
        mask = LayerMask.GetMask(["Environment","EnvironmentBaked","OutdoorsBaked"]);
        armature = gameObject.transform.GetChild(0).GetChild(1);
        armatureOffset = new(0, 0, 0);
        angleOffset = new(0,0,0);

        leftRayPoint = armature.GetChild(0).GetChild(2);
        rightRayPoint = armature.GetChild(0).GetChild(3);

        leftTarget = transform.GetChild(1).GetChild(0).GetChild(0);
        rightTarget = transform.GetChild(1).GetChild(1).GetChild(0);

        nonPhysicalLegs = transform.GetChild(0);
        physicalLegs = transform.GetChild(2);
        physicalArmature = physicalLegs.GetChild(1);

        HealthyLeft = armature.parent.GetChild(0).GetComponent<SkinnedMeshRenderer>();
        HealthyRight = armature.parent.GetChild(2).GetComponent<SkinnedMeshRenderer>();

        DamagedLeft = armature.parent.GetChild(3).GetComponent<SkinnedMeshRenderer>();
        DamagedRight = armature.parent.GetChild(4).GetComponent<SkinnedMeshRenderer>();

        ensims = transform.GetComponentsInChildren<EnemySimplifier>();

        footstepDestination = transform.GetChild(3);
        footstepsController = footstepDestination.GetComponent<Footsteps>();

        physicalLegs.gameObject.SetActive(false);
        DamagedLeft.enabled = false;
        DamagedRight.enabled = false;
    }

    void Start()
    {
        StepLeft();
    }

    public void FixedUpdate()
    {
        armature.position = movingBody.position + armatureOffset;
        armature.eulerAngles = new Vector3(armature.eulerAngles.x,turningBody.eulerAngles.y,armature.eulerAngles.z) + angleOffset;
        leftTarget.position = Vector3.Lerp(leftTarget.position,leftTargetTarget,lerpSpeed);
        rightTarget.position = Vector3.Lerp(rightTarget.position,rightTargetTarget,lerpSpeed);
    }

    void StepLeft()
    {
        if(malFace.spiderFalling) {return;}
        Invoke("StepRight",stepTime);
        if(!isPhysical)
        {
            if (Physics.Raycast(leftRayPoint.position, leftRayPoint.up, out RaycastHit hit, mask))
            {
                toTargetTarget = hit.point + Vector3.up;
                if(Vector3.Distance(toTargetTarget,leftTarget.position) > 0.2f)
                {
                    Invoke("MakeFootstep",stepTime - 0.45f);
                }
                leftTargetTarget = toTargetTarget;
            }
        }
    }

    void StepRight()
    {
        if(malFace.spiderFalling) {return;}
        Invoke("StepLeft",stepTime);
        if(!isPhysical) {
            if(Physics.Raycast(rightRayPoint.position, rightRayPoint.up, out RaycastHit hit, mask))
            {
                toTargetTarget = hit.point + Vector3.up;
                if(Vector3.Distance(toTargetTarget,rightTarget.position) > 0.2f)
                {
                    Invoke("MakeFootstep",stepTime - 0.45f);
                }
                rightTargetTarget = toTargetTarget;
            }
        }
    }

    void MakeFootstep()
    {
        footstepDestination.position = toTargetTarget;
        footstepDestination.eulerAngles = new(0,turningBody.eulerAngles.y,0);
        footstepsController.Footstep();
    }

    public void SwitchToPhysicalLegs()
    {
        if(!isPhysical)
        {
            isPhysical = true;
            physicalLegs.gameObject.SetActive(true);
            armatureOffset = new(0,0,0);
            physicalArmature.position = movingBody.position + armatureOffset;
            physicalArmature.rotation = armature.rotation;

            nonPhysicalLegs.gameObject.SetActive(false);
        }
    }

    public void SwitchToDamagedVisuals()
    {
        alreadyChangedModel = true;

        HealthyLeft.enabled = false;
        HealthyRight.enabled = false;

        DamagedLeft.enabled = true;
        DamagedRight.enabled = true;
    }
    
    public void SwitchToHealthyVisuals()
    {
        alreadyChangedModel = false;

        HealthyLeft.enabled = true;
        HealthyRight.enabled = true;

        DamagedLeft.enabled = false;
        DamagedRight.enabled = false;
    }

    public void Enrage()
    {
        foreach (EnemySimplifier ensim in ensims)
        {
            ensim.enraged = true;
        }
    }
    
    public void UnEnrage()
    {
        foreach (EnemySimplifier ensim in ensims)
        {
            ensim.enraged = false;
        }
    }
}