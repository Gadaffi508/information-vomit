using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{

    public PlanetScript attract;
    private Transform playerTransform;


    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }

    private void FixedUpdate()
    {
        if (attract)
        {
            attract.Attract(playerTransform);
        }
    }
}
