using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    static WebCamTexture backCam;

    private void Start()
    {
        if (backCam == null)
        {
            backCam = new WebCamTexture();

            GetComponent<Renderer>().material.mainTexture = backCam;
        }

        if (!backCam.isPlaying)
        {
            backCam.Play();
        }
    }
}
