using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Damage(float damageTaken)
    {
        //
    }

    public void kill()
    {
       //Do something fun
    }
}
