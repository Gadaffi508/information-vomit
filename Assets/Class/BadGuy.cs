using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        this.name = newName;
        this.power = newPower;
    }

    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }
        return power - other.power;
    }
}
