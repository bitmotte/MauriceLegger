using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBody : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position += transform.forward / 12;
    }
}
