using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesExample : MonoBehaviour
{
    public float smoothing = 1f;
    public Transform target;

    private void Start()
    {
        StartCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance(transform.position,target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position,target.position,smoothing * Time.deltaTime);

            yield return null;
        }

        Debug.Log("Reached the target");

        yield return new WaitForSeconds(3f);

        Debug.Log("MyCoroutine is now finished.");
    }
}
