using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrablePoint;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectGrable objectGrables;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrables == null)
            {
                float pickUpD�stance = 2;
                Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpD�stance, pickUpLayerMask);
                if (raycastHit.transform.TryGetComponent(out objectGrables))
                {
                    objectGrables.Grab(objectGrablePoint);
                }
            }
            else
            {
                objectGrables.Drop();
                objectGrables = null;
            }
        }
        float rotationAmount = Input.GetAxis("Mouse ScrollWheel");
        if (rotationAmount != 0 && objectGrables != null)
        {
            objectGrables.RotateObject(rotationAmount * 50);
        }
    }
}
