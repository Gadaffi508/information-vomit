using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClassAt2 : MonoBehaviour
{
    public Transform target;

    public float radius = 5;

    private void Start()
    {
        float perimeter = 2.0f * Mathf.PI * radius;
        Debug.Log("The perimeter of the circle is: " + perimeter);
    }

    void Update()
    {
        Vector3 relative = transform.InverseTransformPoint(target.position);
        float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;
        transform.Rotate(0, angle, 0);
    }
}
