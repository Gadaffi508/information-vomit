using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeController : MonoBehaviour
{
    public Image �mageone;
    public Image �magesecond;
    bool changed = true;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            UnityEngine.Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float touchDelta = touch.deltaPosition.x;

                if (touchDelta > 0)
                {
                    // Sa�a kayd�rma i�lemi
                    if (changed == true)
                    {
                        �mageone.transform.localPosition = new Vector3(300, 0, 0);
                        �magesecond.transform.localPosition = new Vector3(100, 0, 0);
                        changed = false;
                        StartCoroutine(DelayChanged());
                    }
                }
                else if (touchDelta < 0)
                {
                    // Sola kayd�rma i�lemi
                    if (changed == true)
                    {
                        �mageone.transform.localPosition = new Vector3(100, 0, 0);
                        �magesecond.transform.localPosition = new Vector3(-100, 0, 0);
                        changed = false;
                        StartCoroutine(DelayChanged());
                    }
                }
            }
        }
    }

    IEnumerator DelayChanged()
    {
        yield return new WaitForSeconds(.5f);
        changed = true;

    }
}
