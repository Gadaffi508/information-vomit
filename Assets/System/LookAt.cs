using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    GameObject tagret;
    // Start is called before the first frame update
    void Start()
    {
        tagret = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(tagret.transform.position.x,transform.position.y,tagret.transform.position.z);

        transform.LookAt(targetPos);
    }
}
