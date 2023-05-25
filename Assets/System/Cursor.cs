using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Releases the cursor
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        // Locks the cursor
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        // Confines the cursor
        UnityEngine.Cursor.lockState = CursorLockMode.Confined;

        UnityEngine.Cursor.lockState = CursorLockMode.Locked;

        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
