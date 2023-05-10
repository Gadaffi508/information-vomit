using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    Vector2 pointOnGround;
    Vector3 heading;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        var pointInAir = pointOnGround + new Vector2(0, 5);
        Debug.Log(pointInAir);

        var distance = heading.magnitude;
        var direction = heading / distance; // This is now the normalized direction.
        Debug.Log(direction);

        var fwdSpeed = Vector3.Dot(rb.velocity, transform.forward);
        Debug.Log(fwdSpeed);
    }
}
