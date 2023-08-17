using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionInput : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}
