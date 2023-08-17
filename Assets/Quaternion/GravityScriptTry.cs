using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScriptTry : MonoBehaviour
{
    [SerializeField] private Transform m_tatget;

    private void Update()
    {
        Vector3 relativePos = (m_tatget.position + new Vector3(0, 1.5f, 0)) - transform.position; //up position
        Quaternion rotation = Quaternion.LookRotation(relativePos); // look rotation

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current,rotation, Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
