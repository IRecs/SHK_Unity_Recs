using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BonusObject : MonoBehaviour
{
    protected float Duration => _duration;
    protected float Force => _force;

    [SerializeField] private float _force;
    [SerializeField] private float _duration;

    protected abstract void ArrangeBonus(Unit unit);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Unit unit))
        {
            ArrangeBonus(unit);
            gameObject.SetActive(false);
        }
    }
}
