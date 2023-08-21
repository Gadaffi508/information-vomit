using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        EventManager.onClicked += turnColor;
    }

    private void OnDisable()
    {
        EventManager.onClicked -= turnColor;
    }

    void turnColor()
    {
        Color col = new Color(Random.value,Random.value,Random.value);
        renderer.material.color = col;
    }
}
