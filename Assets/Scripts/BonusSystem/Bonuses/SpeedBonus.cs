using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : Bonus
{
    private Mover _mover;

    protected override void EnableBonus()
    {
        if(_mover == null)
            _mover = GetComponentInParent<Mover>();

        _mover.ChangeSpeed(Force);
    }

    protected override void DisableBonus()
    {
        float reverseForce = 1 / Force;
        _mover.ChangeSpeed(reverseForce);
        this.enabled = false;
    }    
}
