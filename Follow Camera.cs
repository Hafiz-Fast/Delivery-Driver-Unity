using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject CameraPos;
    void LateUpdate()
    {
        transform.position = CameraPos.transform.position + new Vector3(0, 0, -10);
    }
}
