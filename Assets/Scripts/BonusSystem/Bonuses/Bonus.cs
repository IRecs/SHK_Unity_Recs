using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bonus : MonoBehaviour
{
    protected float Force { get; private set; }
    protected float Duration { get; private set; }


    private void Update()
    {
        Duration -= Time.deltaTime;

        if(Duration <= 0)
        {
            DisableBonus();
        }
    }

    protected abstract void EnableBonus();

    protected abstract void DisableBonus();

    public void SetParameters(float forceBonus, float durationBonus)
    {
        if (forceBonus > 0)
            Force = forceBonus;

        if (durationBonus > 0)
            Duration += durationBonus;

        EnableBonus();
    }
}
