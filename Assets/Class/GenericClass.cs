using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass <T>
{
    T item;

    public void Update›tem(T newitem)
    {
        item = newitem;
        Debug.Log(item);
    }
}
