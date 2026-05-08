using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject followThings;
    Vector3 offSet = new Vector3(0, 0, -10);
    void LateUpdate()
    {
        transform.position = followThings.transform.position + offSet;
    }
}
