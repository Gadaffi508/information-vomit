using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandominsideUnitCircle : MonoBehaviour
{
    void Start()
    {
        // Sets the position to be somewhere inside a circle
        // with radius 5 and the center at zero. Note that
        // assigning a Vector2 to a Vector3 is fine - it will
        // just set the X and Y values.
        transform.position = Random.insideUnitCircle * 5;
        transform.position = Random.insideUnitSphere * 5;

        GetComponent<Rigidbody>().velocity = Random.onUnitSphere * 10;
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Rotate!"))
        {
            transform.rotation = Random.rotation;
        }
    }

    void OnMouseDown()
    {
        // Pick a random, saturated and not-too-dark color
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
