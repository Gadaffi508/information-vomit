using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothStep : MonoBehaviour
{
    // Minimum and maximum values for the transition.
    public float minimum = 10.0f;
    public float maximum = 20.0f;

    // Time taken for the transition.
    float duration = 5.0f;

    float startTime;

    void Start()
    {
        // Make a note of the time the script started.
        startTime = Time.time;
    }

    void Update()
    {
        // Calculate the fraction of the total duration that has passed.
        float t = (Time.time - startTime) / duration;
        transform.position = new Vector3(Mathf.SmoothStep(minimum, maximum, t), 0, 0);
    }
}
