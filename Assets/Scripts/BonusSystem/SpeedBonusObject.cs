using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonusObject : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover mover))
        {
            mover.EnableSpeedBoost(_duration);
            gameObject.SetActive(false);
        }
    }
}
