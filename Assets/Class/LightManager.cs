using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataClass
{
    public int myInt;
    public float myFloat;
}

public class LightManager : MonoBehaviour
{
    public DataClass dataClass;

    [SerializeField] private Light m_light;

    private void Awake()
    {
        int myVar = AddTwo(9,2);
        Debug.Log(myVar);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyFunction();
        }
    }

    void MyFunction()
    {
        m_light.enabled = !m_light.enabled;
    }

    int AddTwo(int var1, int var2)
    {
        int returnValue = var1 + var2;
        return returnValue;
    }
}
