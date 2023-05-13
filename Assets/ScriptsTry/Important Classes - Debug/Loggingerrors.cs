using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loggingerrors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is a log message.");
        Debug.LogWarning("This is a warning message!");
        Debug.LogError("This is an error message!");

        Debug.LogWarning("I come in peace!", this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        float height = transform.position.y;
        Debug.DrawLine(transform.position, transform.position - Vector3.up * height, Color.magenta, 4);
        
    }
}
