using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    void LateUpdate () {
        Vector3 desiredposition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);

        transform.position = smoothPosition;
    }
}
