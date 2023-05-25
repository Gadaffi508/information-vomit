using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            // touch
        }
        else
        {
            // No touch
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
