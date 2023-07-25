using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    private void Start()
    {
        SomeClass someClass = new SomeClass();

        int numbers = someClass.Add(5,5);
        string texts = someClass.Add("Yusuf", " Arslan");

        Debug.Log(numbers);
        Debug.Log(texts);
        Debug.Log("---------------------------------------------");

        int numberSecond = someClass.GenereticMethod<int>(5);
        Debug.Log(numberSecond);

        Debug.Log("---------------------------------------------");

        GenericClass<int> myClass = new GenericClass<int>();

        myClass.Update›tem(5);

        Debug.Log("---------------------------------------------");
    }
}
