using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject[] coin;

    private void FixedUpdate()
    {
        for (int i = 0; i < coin.Length; i++)
        {
            if (coin[i] != null)
            {
                coin[i].transform.Rotate(0, 0, 90 * Time.deltaTime);
            }
        }
    }
}
