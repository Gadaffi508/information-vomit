using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNetwork : MonoBehaviour
{
    float speed = 50;
    // Start is called before the first frame update
    void Start()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            Debug.Log("Network Avaliable");
        }
        else
        {
            Debug.Log("Network Not Avaliable");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);   
    }
}
