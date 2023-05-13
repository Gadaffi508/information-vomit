using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomValuee : MonoBehaviour
{
    void Start()
    {
        Color randomColor = RandomColor();
        Debug.Log(randomColor);
    }

    // Generate a random color value.
    Color RandomColor()
    {
        // A different random value is used for each color component (if
        // the same is used for R, G and B, a shade of grey is produced).
        return new Color(Random.value, Random.value, Random.value);
    }
}
