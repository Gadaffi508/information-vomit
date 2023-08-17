using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScriptTry : MonoBehaviour
{
    [Range(-100, 100)][SerializeField] private int m_speed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, m_speed * Time.deltaTime, 0));
    }
}
