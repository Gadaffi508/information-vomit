using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCapsuleScript : MonoBehaviour
{

    public float moveSpeed;

    private Vector3 moveDireciton;

    private void Update()
    {
        moveDireciton = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDireciton));
    }
}
