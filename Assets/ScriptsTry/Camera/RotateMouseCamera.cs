using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMouseCamera : MonoBehaviour
{
    public float speedH = 2;
    public float speedV = 2;

    private float yaw = 0;
    private float pitch = 0;

    private void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw,0);
    }
}
