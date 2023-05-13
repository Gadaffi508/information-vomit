using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRange : MonoBehaviour
{
    public GameObject prefab;
    public float zoffset = 10;

    // Click the "Instantiate!" button and a new grid of `prefab` objects will be
    // instantiated with a random number of items in each direction.
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 50), "Instantiate!"))
        {
            // the grid will always be 1, 2, 3, 4, or 5 prefabs wide
            int xcount = Random.Range(1, 6);
            // the grid will always be 2, 3, or 4 prefabs long
            int ycount = Random.Range(2, 5);

            for (int x = 0; x != xcount; ++x)
            {
                for (int y = 0; y != ycount; ++y)
                {
                    var position = new Vector3(x * 2, zoffset, y * 2);
                    Instantiate(prefab, position, Quaternion.identity);
                }
            }

            zoffset += 2;
        }
    }
}
