using UnityEngine;

namespace MauriceLegger;
public class LegsController : MonoBehaviour
{
    public Transform turningBody;
    Transform armature;



    void Awake()
    {
        armature = gameObject.transform.GetChild(0).GetChild(1);
    }

    void Update()
    {
        //WHY IS IT SPINNING FUCK YOU
        //armature.transform.eulerAngles = new Vector3(armature.transform.eulerAngles.x, armature.transform.eulerAngles.y, turningBody.transform.eulerAngles.y);
        //armature.transform.position = turningBody.transform.position;
    }
}