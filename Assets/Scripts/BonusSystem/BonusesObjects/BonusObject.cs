using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BonusObject : MonoBehaviour
{
    [SerializeField] protected float Duration { get; }
    [SerializeField] protected float Force { get; }

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
