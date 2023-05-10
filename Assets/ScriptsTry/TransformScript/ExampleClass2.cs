using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass2 : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
        Debug.Log(angle);
        //transform.rotation = Quaternion.AngleAxis(30*Time.time*10, Vector3.up);

        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
    }
}
