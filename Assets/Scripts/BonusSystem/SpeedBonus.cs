using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    private float _forceEffect;
    private float _durationEffect;

    private PlayerMover _mover;

    private void Update()
    {
        _durationEffect -= Time.deltaTime;

        if (_durationEffect <= 0)
        {
            DisableBonus();
        }
    }

    public void EnableBonusEffect()
    {
        if (_mover == null)
            _mover = GetComponentInParent<PlayerMover>();

        _mover.ChangeSpeed(_forceEffect);
    }

    private void DisableBonus()
    {
        _mover.ChangeSpeed(1 / _forceEffect);
        _forceEffect = 0;
        this.enabled = false;
    }

    public bool TrySetForce(float forceBonus)
    {
        if (forceBonus > 0 && forceBonus > _forceEffect)
        {
            _forceEffect = forceBonus;
            return true;
        }
        else
            return false;
    }

    public void SetDuration(float durationBonus)
    {
        if (durationBonus > 0)
            _durationEffect += durationBonus;
    }
}
