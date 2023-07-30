using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassBadguy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List <BadGuy> Blist = new List <BadGuy>();

        Blist.Add(new BadGuy("Eda",20));
        Blist.Add(new BadGuy("P�nar",5));
        Blist.Add(new BadGuy("R�meysa",20));

        Blist.Sort();

        foreach (BadGuy guy in Blist)
        {
            Debug.Log(guy.name +" "+ guy.power);
        }

        Blist.Clear();
    }
}
