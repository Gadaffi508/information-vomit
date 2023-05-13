using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp01 : MonoBehaviour
{
    // Set the position of the transform to be that of the time
    // but never less than 0 or more than 1

    public float startValue = -0.5f;
    public float endValue = 1.5f;

    private float timeCount = 0.0f;

    private void Start()
    {
        // Prints 10
        Debug.Log(Mathf.Ceil(10.0F));
        // Prints 11
        Debug.Log(Mathf.Ceil(10.2F));
        // Prints 11
        Debug.Log(Mathf.Ceil(10.7F));
        // Prints -10
        Debug.Log(Mathf.Ceil(-10.0F));
        // Prints -10
        Debug.Log(Mathf.Ceil(-10.2F));
        // Prints -10
        Debug.Log(Mathf.Ceil(-10.7F));

        Debug.Log(Mathf.Floor(10.0F));   // Prints  10
        Debug.Log(Mathf.Floor(10.2F));   // Prints  10
        Debug.Log(Mathf.Floor(10.7F));   // Prints  10
        Debug.Log(Mathf.Floor(-10.0F));  // Prints -10
        Debug.Log(Mathf.Floor(-10.2F));  // Prints -11
        Debug.Log(Mathf.Floor(-10.7F));  // Prints -11

        // prints 2.584963
        Debug.Log(Mathf.Log(6, 2));

        // prints 4.60517
        Debug.Log(Mathf.Log(100));

        // Prints 2
        print(Mathf.Log10(100));
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp01(Time.time), 0, 0);
    }

    void FixedUpdate()
    {
        timeCount += Time.deltaTime;

        if (timeCount > 1.0f)
        {
            float result = Random.value;
            result = result * (endValue - startValue);
            result = result + startValue;

            float clampValue = Mathf.Clamp01(result);

            Debug.Log("value: " + result.ToString("F3") + " result: " + clampValue.ToString("F3"));

            timeCount = 0.0f;
        }
    }
}
