using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScriptTry : MonoBehaviour
{
    [SerializeField]private Transform m_target;

    private void Update()
    {
        Vector3 relativePos = m_target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
