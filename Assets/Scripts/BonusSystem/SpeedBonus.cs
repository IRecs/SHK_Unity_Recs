using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    private PlayerMover _mover;

    public void Enable(float force, float duration)
    {     
        StartCoroutine(OnEnebel(force, duration));
    }

    private IEnumerator OnEnebel(float force, float duration)
    {
        if (_mover == null)
            _mover = GetComponentInParent<PlayerMover>();

        _mover.ChangeSpeed(force);
        yield return new WaitForSeconds(duration);
        _mover.ChangeSpeed(1 / force);
    }
}
