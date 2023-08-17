using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScriptTry : MonoBehaviour
{
    [SerializeField] private Color _color;
    // Start is called before the first frame update
    void Start()
    {
        Renderer ren = GetComponent<Renderer>();
        ren.sharedMaterial.color = _color;
    }
}
