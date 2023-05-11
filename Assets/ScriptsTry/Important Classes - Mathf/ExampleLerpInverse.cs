using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleLerpInverse : MonoBehaviour
{
    public float start = 20.0f;
    public float end = 40.0f;
    public float currentProgress = 22.0f;

    void Start()
    {
        // the progress between start and end is stored as a 0-1 value, in 'i'
        float i = Mathf.InverseLerp(start, end, currentProgress);

        // this will display "Current progress: 0.1 or 10%" in Console window
        Debug.Log("Current progress: " + i + " or " + i * 100 + "%");

        // the needle of an on-screen dial could then be set to a
        // rotational angle out of 360 degrees, based on the progress.
        float dialNeedleAngle = i * 360;

        //// this will display "Needle angle: 36" in Console window
        Debug.Log("Needle angle: " + dialNeedleAngle);
    }
}
