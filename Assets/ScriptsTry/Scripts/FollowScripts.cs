using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScripts : MonoBehaviour
{
    public GameObject target;
    public float distance;
    public float height;

    void LateUpdate()
    {
        // Calculate the position of the target.
        Vector3 targetPosition = target.transform.position;

        // Calculate the offset from the target.
        Vector3 offset = new Vector3(0, height, distance);

        // Set the position of the camera.
        transform.position = targetPosition + offset;
    }
}
