using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    GameObject getTarget;
    bool isMouseDragging;
    Vector3 offsetValue;
    Vector3 positionOfScreen;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            getTarget = ReturnClickedObject(out hitInfo);
            if (getTarget != null)
            {
                isMouseDragging = true;

                positionOfScreen = Camera.main.WorldToScreenPoint(getTarget.transform.position);

                offsetValue = getTarget.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
            }

            if (Input.GetMouseButtonUp(0))
            {
                isMouseDragging = false;
            }

            if (isMouseDragging)
            {
                Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

                Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace) + offsetValue;

                getTarget.transform.position = currentPosition;
            }
        }
    }
    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin,ray.direction * 10,out hit))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}
