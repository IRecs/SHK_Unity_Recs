using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : Bonus
{
    private BeingMover _mover;

    public SpeedBonus(BeingMover mover, float forceBonus)
    {
        _mover = mover;
        ForceBonus = forceBonus;
    }

    public override void EnableBonus()
    {
        _mover.SpeedUp(ForceBonus);
    }

    public override void DisableBonus()
    {
        _mover.ReturnStandardSpeed();
    }
}
