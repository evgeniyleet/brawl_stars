using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform Target, SelfTransform;

    
    private void LateUpdate()
    {
        SelfTransform.position = Vector3.Lerp(SelfTransform.position, Target.position + new Vector3(0, 0, -10), 0.2f);
       // SelfTransform.position = Target.position + new Vector3(0, 0, -10);
    }
}
