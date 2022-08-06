using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
    public float smoothSpeed = 0.005f;

    void LateUpdate()
    {
        //Vector3 desiredPosition = Target.position + offset;
        Vector3 desiredPosition = transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
