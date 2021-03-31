using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObject : MonoBehaviour
{
    [SerializeField] protected float DurationBonus;
    [SerializeField] protected float ForceBonus;

    public void GetBonusMetrics(out float durationBonus, out float forceBonus)
    {
        durationBonus = DurationBonus;
        forceBonus = ForceBonus;
    }
}
