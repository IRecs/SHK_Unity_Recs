using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bonus : object
{
    protected float ForceBonus;   

    public abstract void EnableBonus();

    public abstract void DisableBonus();
}
