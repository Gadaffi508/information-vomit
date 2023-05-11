using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMoveTower : MonoBehaviour
{
    float currStrength;
    float maxStrength;
    float recoveryRate;

    void Update()
    {
        currStrength = Mathf.MoveTowards(currStrength, maxStrength, recoveryRate * Time.deltaTime);
        Debug.Log(currStrength);
    }
}
