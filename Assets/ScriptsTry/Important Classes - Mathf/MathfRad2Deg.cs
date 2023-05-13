using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathfRad2Deg : MonoBehaviour
{
    public float rad = 2.0f;
    public float deg = 30.0F;

    void Start()
    {
        float _deg = rad * Mathf.Rad2Deg;
        //This will output 1 radians are equal to 57.29578 degrees
        Debug.Log(rad + " radians are equal to " + _deg + " degrees.");

        float _rad = deg * Mathf.Deg2Rad;
        Debug.Log(deg + " degrees are equal to " + _rad + " radians.");

        // prints 8
        Debug.Log(Mathf.ClosestPowerOfTwo(7));

        // prints 16
        Debug.Log(Mathf.ClosestPowerOfTwo(19));

        //Prints 8 to the console
        Debug.Log(Mathf.NextPowerOfTwo(7));

        //Prints 256 to the console
        Debug.Log(Mathf.NextPowerOfTwo(139));

        //Prints 256 to the console
        Debug.Log(Mathf.NextPowerOfTwo(256));

        // prints false
        Debug.Log(Mathf.IsPowerOfTwo(7));

        // prints true
        Debug.Log(Mathf.IsPowerOfTwo(32));

        Debug.Log(Mathf.Max(1.2f, 2.4f));

        Debug.Log(Mathf.Min(1.2f, 2.4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
