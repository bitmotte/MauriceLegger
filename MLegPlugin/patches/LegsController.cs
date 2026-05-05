//listen theres a  lot of jank in this file im sorry ill fix it later but for now im done with this ! ! aafaggsfh


using UnityEngine;

namespace MauriceLegger;

public class LegsController : MonoBehaviour
{
    public MaliciousFace malFace;

    public Animator stateController;

    public bool variant;

    //leg animation things
    Transform turningBody;

    public float lerpSpeed = 0.2f;
    public float stepDistance = 0.9f;
    public Transform leftRayPoint;
    public Transform rightRayPoint;

    public Transform leftIKTarget;
    public Transform rightIKTarget;

    public Transform leftIKDestination;
    public Transform rightIKDestination;

    public LayerMask mask;

    Vector3 malFacePreviousPos;

    //physical legs
    Transform physicalContainer;
    Transform physical;

    //footsteps
    Footsteps footstepsController;

    EnemySimplifier[] ensims = [];

    //this script has gotten so bloated

    void Awake()
    {
        ensims = GetComponentsInChildren<EnemySimplifier>();
    }

    void Start()
    {
        foreach (EnemySimplifier ensim in ensims)
        {
            ensim.eid = malFace.eid;
            ensim.enemyColorType = EnemyType.Cerberus;
        }

        stateController = GetComponent<Animator>();

        turningBody = transform.parent.GetChild(0);

        mask = LayerMask.GetMask(["Environment","EnvironmentBaked","OutdoorsBaked"]);

        leftRayPoint = transform.GetChild(2);
        rightRayPoint = transform.GetChild(3);

        //the points the leg points at
        Transform IKRig = transform.GetChild(1);
        leftIKTarget = IKRig.GetChild(0);
        rightIKTarget = IKRig.GetChild(1);

        //the points the leg lerps to
        Transform IKDestinations = transform.GetChild(0);
        leftIKDestination = IKDestinations.GetChild(0);
        rightIKDestination = IKDestinations.GetChild(1);

        //physical legs
        physicalContainer = transform.GetChild(4);
        physical = physicalContainer.GetChild(1);

        physicalContainer.gameObject.SetActive(false);

        footstepsController = transform.GetComponentInChildren<Footsteps>();
        footstepsController.footstep.AddComponent<FootstepConfigCheck>();

        IKDestinations.parent = transform.parent.parent;

        StepLeft();

        if(variant)
        {
            stateController.SetBoolString("Variant",true);
        }

        CheckConfig();
    }

    void FixedUpdate()
    {
        transform.eulerAngles = new(0,turningBody.eulerAngles.y,0);

        leftIKTarget.position = Vector3.Lerp(leftIKTarget.position, leftIKDestination.position,lerpSpeed);
        rightIKTarget.position = Vector3.Lerp(rightIKTarget.position, rightIKDestination.position,lerpSpeed);
    }

    void CheckConfig()
    {
        Invoke("CheckConfig",3f);
        lerpSpeed = GlobalConfig.footLerpSpeed;
        stepDistance = GlobalConfig.timeBetweenSteps;
    }

    void StepLeft()
    {
        //mmm jank : - )
        if(malFace.spiderFalling) {return;}
        Invoke("StepRight",stepDistance / 2);
        
        if (Physics.Raycast(leftRayPoint.position + (-leftRayPoint.forward), leftRayPoint.up, out RaycastHit hit, mask))
        {
            leftIKDestination.position = hit.point;

            if(Vector3.Distance(malFace.transform.position,malFacePreviousPos) >= stepDistance)
            {
                Invoke("MakeFootstepLeft",.1f);
                leftIKDestination.position = hit.point + (-leftRayPoint.forward * stepDistance);
            }
        }

        malFacePreviousPos = malFace.transform.position;
    }

    void StepRight()
    {
        //mmm jank : - )
        if(malFace.spiderFalling) {return;}
        Invoke("StepLeft",stepDistance / 2);
        
        if (Physics.Raycast(rightRayPoint.position + (-rightRayPoint.forward), rightRayPoint.up, out RaycastHit hit, mask))
        {
            rightIKDestination.position = hit.point;

            if(Vector3.Distance(malFace.transform.position,malFacePreviousPos) >= stepDistance)
            {
                Invoke("MakeFootstepRight",.1f);
                rightIKDestination.position = hit.point + (-rightRayPoint.forward * stepDistance);
            }
        }

        malFacePreviousPos = malFace.transform.position;
    }

    void MakeFootstepLeft()
    {
        if(!GlobalConfig.footsteps) {return;}
        footstepsController.transform.position = leftIKDestination.position;
        footstepsController.transform.eulerAngles = new(0,turningBody.eulerAngles.y,0);
        footstepsController.Footstep();
    }

    void MakeFootstepRight()
    {
        if(!GlobalConfig.footsteps) {return;}
        footstepsController.transform.position = rightIKDestination.position;
        footstepsController.transform.eulerAngles = new(0,turningBody.eulerAngles.y,0);
        footstepsController.Footstep();
    }

    public void SwitchToDamagedVisuals()
    {
        stateController.SetBoolString("Damaged",true);
    }
    
    public void SwitchToHealthyVisuals()
    {
        stateController.SetBoolString("Damaged",false);
    }

    //every time i open this mod some new bullshit problem appears LOOK WHAT THEY MADE ME DO

    public void Enrage()
    {
        if(malFace.eid.puppet) {return;}
        Invoke("EnrageWhat",0.01f);
    }

    public void EnrageWhat()
    {
        stateController.SetBoolString("Enraged",true);
        foreach (EnemySimplifier ensim in ensims)
        {
            ensim.ChangeMaterialNew(EnemySimplifier.MaterialState.enraged,ensim.enragedMaterial);
            ensim.enraged = true;
        }
    }
    
    public void UnEnrage()
    {
        if(malFace.eid.puppet) {return;}
        Invoke("UnEnrageWhat",0.01f);
    }

    public void UnEnrageWhat()
    {
        stateController.SetBoolString("Enraged",false);
        foreach (EnemySimplifier ensim in ensims)
        {
            ensim.ChangeMaterialNew(EnemySimplifier.MaterialState.normal,ensim.originalMaterial);
            ensim.enraged = false;
        }
    }

    public void Death()
    {
        Invoke("DeathWhat",0.01f);
    }

    public void DeathWhat()
    {
        foreach (EnemySimplifier ensim in ensims)
        {
            MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
            materialPropertyBlock.SetFloat("_Outline", 0f);
            materialPropertyBlock.SetFloat("_ForceOutline", 0f);
            ensim.meshrenderer.SetPropertyBlock(materialPropertyBlock);
            ensim.active = false;
            Object.Destroy(ensim);
        }
        DoubleRender[] doubleRenderers = GetComponentsInChildren<DoubleRender>();
        foreach (DoubleRender dr in doubleRenderers)
        {
            Destroy(dr);
        }
    }

    public void SwitchToPhysical()
    {
        physicalContainer.gameObject.SetActive(true);
        physical.parent = transform.parent;
        Destroy(gameObject);
    }
}