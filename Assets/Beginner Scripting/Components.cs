using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Components : MonoBehaviour
{

    private void Start()
    {
        AddingNumbers(5.5f, 18.9f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    void AddingNumbers(float num1, float num2)
    {
        float resultingNumber;
        resultingNumber = num1 + num2;
        Debug.Log(resultingNumber);
    }
}
