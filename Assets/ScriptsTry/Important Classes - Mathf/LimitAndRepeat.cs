using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitAndRepeat : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        myLight.intensity = Mathf.PingPong(Time.time, 8);

        transform.position = new Vector3(Mathf.Repeat(Time.time, 3), transform.position.y, transform.position.z); // tekrar etme
    }
}
