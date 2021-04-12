using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonusObject : BonusObject
{
    protected override void ArrangeBonus(Unit unit)
    {
        if (unit.TryGetComponent(out Mover mover))
        {
            GameObject container = unit.BonusContainer;

            if (!container.TryGetComponent(out SpeedBonus speedBonus))
            {
                speedBonus = container.gameObject.AddComponent<SpeedBonus>();
            }
            else if (speedBonus.enabled == false)
            {
                speedBonus.enabled = true;
            }

            speedBonus.SetParameters(Force, Duration);
        }
    }
}
