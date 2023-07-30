using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassBadguy : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, BadGuy> badguy = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Yusuf",1);
        BadGuy bg2 = new BadGuy("Yusuf",2);

        badguy.Add("gangster",bg1);
        badguy.Add("Mutant",bg2);

        BadGuy magneto = badguy["Mutant"];

        BadGuy temp = null;

        if (badguy.TryGetValue("Birds",out temp))
        {
            Debug.Log("success");
        }
        else
        {
            Debug.Log("Faile");
        }
    }
}
