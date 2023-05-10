using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClass : MonoBehaviour
{
    public GameObject targetGameObject;

    public TargetClass(GameObject _targetGameObject) // List for waiting)
    {
        _targetGameObject = targetGameObject;
        // here a list for waiting
    }

    public static List<TargetClass> targetList = new List<TargetClass>();

   
}

