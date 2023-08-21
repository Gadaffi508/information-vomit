using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.onClicked += teleport;
    }

    private void OnDisable()
    {
        EventManager.onClicked -= teleport;
    }

    void teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(4.0f, 6.0f);
        transform.position = pos;
    }
}
