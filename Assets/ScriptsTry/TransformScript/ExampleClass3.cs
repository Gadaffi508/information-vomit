using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ExampleClass3 : MonoBehaviour
{
    public Transform from;
    public Transform to;

    float speed=5;

    private float timeCount = 0.0f;

    void Update()
    {
        
    }
    public void HedefObjeRotateDönme()
    {
        transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount);
        timeCount = timeCount + Time.deltaTime;
    }
    public void HedefObjeninBaktýðýYerebakma()
    {
        transform.rotation = Quaternion.Inverse(to.rotation);
    }
    public void HedefObjeRotateDönmeYavaþ()
    {
        var step = speed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, to.rotation, step);
    }
    public void RotateBelirliYerdeKalma()
    {
        var rot = transform.rotation;
        rot.x += Time.deltaTime * 10;
        transform.rotation = rot;
    }
}
