using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    private void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemny();
        Humanoid orc = new Orc();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}

public class Orc:Enemny
{
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}

public class Enemny : Humanoid
{
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
