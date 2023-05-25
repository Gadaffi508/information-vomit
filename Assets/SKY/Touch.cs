using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    bool isFiring;
    bool stopFiring;

    public void pointerDown()
    {
        stopFiring = false;
        MakeFireVariableTrue();
    }

    public void pointerUp()
    {
        isFiring= false;    
        stopFiring= true;
    }

    void MakeFireVariableTrue()
    {
        isFiring = true;
    }

    void MakeFireVariableFalse()
    {
        isFiring = false;
        if (stopFiring == false)
        {
            Invoke("MakeFireVariableTrue", 0.5f);
        }
    }

    private void Update()
    {
        if (isFiring)
        {
            MakeFireVariableFalse();
            Debug.Log("Fire");
        }
    }
}
